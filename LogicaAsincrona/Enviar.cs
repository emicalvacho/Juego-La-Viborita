using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using LogicaDelJuego;

namespace LogicaAsincrona
{
    /// <summary>
    /// Esta clase se encarga de enviar la información por los puertos correspondientes
    /// </summary>
    public class Enviar
    {
        #region Atributos (algunos ya instanciados)
        ManualResetEvent todoListo = new ManualResetEvent(false);
        Serializador respuesta = new Serializador();
        private int puerto;
        #endregion

        #region Configurar los datos a enviar
        /// <summary>
        /// Se pasa a 'respuesta' lo que se quiere enviar
        /// </summary>
        /// <param name="game">Se recibe el objeto juego a enviar</param>
        /// <param name="player">Se recibe el objeto jugador a enviar</param>
        public void ConfigurarClase(Juego game, Jugador player)
        {
            respuesta.guardarJuego.SetDatos(game, player);
        }
        #endregion

        #region Lógica asincrónica
        /// <summary>
        /// Inicia el cliente e intenta enviar un objeto al servidor
        /// </summary>
        /// <param name="puerto">Es el puerto por el cual se va a comenzar a enviar la información</param>
        public void Comenzar(int puerto)
        {     
            this.puerto = puerto;
            Console.WriteLine("\n\nCliente esperando por una conexion...");
            todoListo.Reset();         
            Socket emisor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            emisor.BeginConnect(new IPEndPoint(IPAddress.Loopback, puerto), Conectar, emisor);
            todoListo.WaitOne(); // Detiene este hilo hasta que se acepta la conexión
        }

        /// <summary>
        /// Se inicia cuando la conexión fue aceptada por los hosts remotos y se prepara para enviar datos
        /// </summary>
        /// <param name="resultado"></param>
        public void Conectar(IAsyncResult resultado)
        {
            try
            {
                respuesta.Socket = (Socket)resultado.AsyncState;
                respuesta.Socket.EndConnect(resultado);
                byte[] buffer = respuesta.Serializar(); // Rellena el búfer con datos
                respuesta.Socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, Send, respuesta);
            }
            catch (SocketException)
            {
                Console.WriteLine("\n\nServidor caído, reintentando...");
                Thread.Sleep(1000);
                Comenzar(puerto);
            }
        }

        /// <summary>
        /// Termina de enviar los datos, espera una línea de lectura hasta que el hilo se cierra
        /// </summary>
        /// <param name="result"></param>
        public void Send(IAsyncResult result)
        {
            Serializador respuesta = (Serializador)result.AsyncState;
            int size = respuesta.Socket.EndSend(result);
            Console.WriteLine("Enviando dato: " + respuesta.guardarJuego.Jugador.NombreJugador);
            todoListo.Set(); // Señales de hilo para continuar y así enviar otro mensaje
        }
        #endregion
    }
}
