using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LogicaAsincrona
{
    /// <summary>
    /// Esta clase se encarga de abrir los puertos de escucha para poder recibir la información
    /// </summary>
    public class Escuchar
    {
        #region Atributos (algunos ya instanciados)
        ManualResetEvent todoListo = new ManualResetEvent(false);
        public delegate void Recibido(Serializador r);
        public event Recibido objetoRecibido;
        Socket escuchador;
        #endregion

        #region Logica asincrónica
        /// <summary>
        /// Configurar el servidor
        /// </summary>
        /// <param name="puerto">Establesco el puerto por el cual voy a empezar a escuchar</param>
        public void Comenzar(int puerto)
        {
            escuchador = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            escuchador.Bind(new IPEndPoint(IPAddress.Loopback, puerto));
            Console.WriteLine("\n\nServidor iniciado.");
            EsperarRespuesta();
        }

        /// <summary>
        /// Cada 1 segundo se ejecuta esta funcion que revisa el buffer de red en busca de mensajes nuevos
        /// </summary>
        public void EsperarRespuesta()
        {
            todoListo.Reset();
            escuchador.Listen(100);
            escuchador.BeginAccept(Aceptar, escuchador);
        }

        /// <summary>
        /// Comienza cuando se solicita una conexión de entrada
        /// </summary>
        /// <param name="resultado"></param>
        public void Aceptar(IAsyncResult resultado)
        {
            Serializador respuesta = new Serializador();
            respuesta.Socket = ((Socket)resultado.AsyncState).EndAccept(resultado);
            respuesta.Socket.BeginReceive(respuesta.buffer, 0, respuesta.buffer.Length, SocketFlags.None, Receive, respuesta);
        }

        /// <summary>
        /// Recibe los datos, los pone en un buffer y comprueba si necesitamos recibirlos de nuevo
        /// </summary>
        /// <param name="resultado"></param>
        public void Receive(IAsyncResult resultado)
        {
            Serializador respuesta = (Serializador)resultado.AsyncState;
            int read = respuesta.Socket.EndReceive(resultado);
            if (read > 0)
            {
                for (int i = 0; i < read; i++)
                {
                    respuesta.TransmisionBuffer.Add(respuesta.buffer[i]);
                }
                // Necesitamos leer de nuevo si esto es verdad
                if (read == respuesta.buffer.Length)
                {
                    respuesta.Socket.BeginReceive(respuesta.buffer, 0, respuesta.buffer.Length, SocketFlags.None, Receive, respuesta);
                    Console.WriteLine("\n\nNo encaja!");
                }
                else
                {
                    Listo(respuesta);
                }
            }
            else
            {
                Listo(respuesta);
            }
        }

        /// <summary>
        /// Deserializa y emite el objeto recibido
        /// </summary>
        /// <param name="respuesta"></param>
        public void Listo(Serializador respuesta)
        {
            Console.WriteLine("\n\nDeserializando respuesta...");
            Serializador deserializado = respuesta.Deserializar();
            objetoRecibido(deserializado);
            todoListo.Set(); // Hilo de señales para continuar
                             // Así que salta de nuevo al primer bucle y comienza a esperar una conexión de nuevo
        }
        #endregion
    }
}
