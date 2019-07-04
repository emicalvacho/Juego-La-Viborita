using LogicaDelJuego;
using LogicaAsincrona;
using System.Windows.Forms;
using System;
using System.Net;

namespace SocketServidor
{
    /// <summary>
    /// Es la clase Hija derivada de Tablero_Principal lo que cambia de su hermana 
    /// es el puerto y el turno si son iguales. Además de agregarle la lógica asincrona
    /// </summary>
    public partial class Tablero_Principal_Servidor : Tablero_Principal
    {
        #region Atributos
        Tablero_Conexion tableroConexion;
        Enviar enviar;
        Escuchar escuchar;
        #endregion

        #region Constructor
        /// <summary>
        /// Este constructor aparte de inicializar los atributos, muestra el formulario secundario
        /// de conexión, comienza a escuchar cada un segundo y declara a los manejadores de eventos
        /// </summary>
        public Tablero_Principal_Servidor()
        {
            InitializeComponent();
            enviar = new Enviar();
            escuchar = new Escuchar();
            tableroConexion = new Tablero_Conexion("del Equipo Rojo");
            escuchar.Comenzar(4000);
            timerCheckBuffer.Start();
            tableroConexion.Cerrar += new Tablero_Conexion.CerrarFormEventHandler(Tablero_FormClosing);
            tableroConexion.PasarInformacionJuego += new Tablero_Conexion.PasarInformacionEventHandler(ConfiguracionInicial);
            escuchar.objetoRecibido += new Escuchar.Recibido(RecibirInformacion);
            tableroConexion.Show();
        }
        #endregion

        #region Métodos disparados por eventos
        /// <summary>
        /// Llamo al inicializador para completar los campos necesarios y envio la clase por medio
        /// al puerto 3000 para que el cliente pueda recibir la información.
        /// Además oculta el tablero de conexión y muestra el tablero principal
        /// </summary>
        /// <param name="nombre">Recibo el nombre del jugador</param>
        /// <param name="fichas">Recibo el numero de fichas</param>
        public void ConfiguracionInicial(string nombre, int fichas)
        {
            Inicializador(nombre, fichas);
            enviar.ConfigurarClase(juego, jugador);
            enviar.Comenzar(3000);
            tableroConexion.Hide();
            this.Show();
        }

        /// <summary>
        /// Este método se dispara cada vez que se recibe una información y permite actualizar
        /// los campos de acuerdo a esa información
        /// </summary>
        /// <param name="respuesta">Es la respuesta recibida desde el Serializador</param>
        public void RecibirInformacion(Serializador respuesta)
        {
            if (respuesta.guardarJuego.jugador.Turno == -1 && jugador.Turno == -1)
            {
                Console.WriteLine("Turno del servidor");
                jugador.Turno = 1;
                Invoke(new MethodInvoker(delegate { MensajesTurno(); }));
                Invoke(new MethodInvoker(delegate { HabilitarBotones(true); }));
            }

            // Los métodos Invoke me permiten usar los elementos que lo requieran cuando se ejecutan hilos de otros procesos
            Invoke(new MethodInvoker(delegate { ActualizarCampos(respuesta.guardarJuego.Juego, respuesta.guardarJuego.Jugador); }));

            if (respuesta.guardarJuego.jugador.Retirada)
            {
                timerCheckBuffer.Stop();
                Invoke(new MethodInvoker(delegate { HabilitarBotones(false); }));
                Invoke(new MethodInvoker(delegate { MensajeAbandono(); }));
            }

            if (respuesta.guardarJuego.jugador.SinFichasAdversario)
            {
                Invoke(new MethodInvoker(delegate { MensajeSinFichas(); }));
                Invoke(new MethodInvoker(delegate { HabilitarBotones(false); }));
            }
        }
        #endregion

        #region Botones
        /// <summary>
        /// Envío la información por el puerto 3000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ClickNumeroElegido(object sender, EventArgs e)
        {
            base.ClickNumeroElegido(sender, e);
            enviar.ConfigurarClase(juego, jugador);
            enviar.Comenzar(3000);
        }

        /// <summary>
        /// Envío la información por el puerto 3000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ClickCubilete(object sender, EventArgs e)
        {
            base.ClickCubilete(sender, e);
            enviar.ConfigurarClase(juego, jugador);
            enviar.Comenzar(3000);
        }
        #endregion

        #region Métodos sobrescrito
        /// <summary>
        /// Determino el turno inicial pero si son iguales la cantidad de fichas el turno es
        /// del Equipo Rojo
        /// </summary>
        public override void DeterminarTurnoInicial()
        {
            base.DeterminarTurnoInicial();
            if(jugador.NumeroFichasActual == jugador.NumeroFichasAdversario)
            {
                jugador.Turno = 1;
            }
        }

        /// <summary>
        /// Envío por el puerto 3000 el turno al jugador cuando su adversario se quedó sin fichas
        /// </summary>
        /// <param name="mensaje">Recibo el mensaje de las fichas</param>
        public override void EstadoDeFichas(string mensaje)
        {
            base.EstadoDeFichas(mensaje);
            enviar.ConfigurarClase(juego, jugador);
            enviar.Comenzar(3000);
        }
        #endregion

        #region Timer de Escucha
        /// <summary>
        /// Este tick se hace cada un segundo esperando la respuesta del adversario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCheckBuffer_Tick(object sender, EventArgs e)
        {
            escuchar.EsperarRespuesta();
        }
        #endregion

        #region Cerrando tablero
        /// <summary>
        /// Cuando se cierra el tablero se envía la información de que el jugador se ha retirado
        /// por el puerto 3000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void Tablero_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.Tablero_FormClosing(sender, e);
            if (comienzo && DialogResult.Yes == salir)
            {
                jugador.Turno = -1;
                jugador.Retirada = true;
                if (!jugador.RetiradaAdversario)
                {
                    enviar.ConfigurarClase(juego, jugador);
                    enviar.Comenzar(3000);
                }
            }
        }
        #endregion

        #region MenuStrip
        /// <summary>
        /// Este método me permite determinar el turno inicial y habilitar los botones de acuerdo a ello
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.nuevoJuegoToolStripMenuItem_Click(sender, e);
            DeterminarTurnoInicial();
            MensajesTurno();
            if (jugador.Turno == 1)
            {
                HabilitarBotones(true);
            }
            else
            {
                HabilitarBotones(false);
            }
        }

        /// <summary>
        /// Este método me permite mostrar el ranking según el nombre del equipo al cual pertenece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void rakingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.rakingToolStripMenuItem_Click(sender, e);
            Tablero_Ranking tablero_Ranking = new Tablero_Ranking("del Equipo Rojo");
            tablero_Ranking.Show();
        }

        /// <summary>
        /// Este método permite al usuario para quedar registrado en el ranking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void finalizarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.finalizarJuegoToolStripMenuItem_Click(sender, e);
            if (jugador.Turno == 1)
            {
                DialogResult dr = MessageBox.Show("¿Deseas retirarte del juego?", "Retirada", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (DialogResult.Yes == dr)
                {
                    HabilitarBotones(false);
                    finalizarJuegoToolStripMenuItem.Enabled = false;
                    jugador.Retirada = true;
                    jugador.VerResultado();
                    ranking.Agregar(jugador);
                    serializarRanking.Serializador(ranking);
                    if (!jugador.RetiradaAdversario)
                    {
                        enviar.ConfigurarClase(juego, jugador);
                        enviar.Comenzar(3000);
                    }
                }
            }
        }

        /// <summary>
        /// Este método permite al usuario abandonar el juego sin quedar registrado en el ranking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void abandonarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.abandonarJuegoToolStripMenuItem_Click(sender, e);
            if (jugador.Turno == 1)
            {
                DialogResult dr = MessageBox.Show("¿Deseas abandornar el juego?", "Abandonar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (DialogResult.Yes == dr)
                {
                    HabilitarBotones(false);
                    jugador.Retirada = true;
                    if (!jugador.RetiradaAdversario)
                    {
                        enviar.ConfigurarClase(juego, jugador);
                        enviar.Comenzar(3000);
                    }
                    Application.Exit();
                }
            }
        }
        #endregion
    }
}
