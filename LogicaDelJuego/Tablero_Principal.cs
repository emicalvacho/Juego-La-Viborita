using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LogicaDelJuego
{
    /// <summary>
    /// Este es el formulario principal en donde el usuario podrá interactuar con el juego
    /// </summary>
    public partial class Tablero_Principal : Form
    {
        #region Atributos
        public Jugador jugador;
        public Juego juego;
        public bool comienzo;
        public DialogResult salir;
        public Ranking ranking;
        public SerializarRanking serializarRanking;
        #endregion

        #region Constructor e Inicializador
        /// <summary>
        /// Constructor que inicializa a los atributos, deserializa el ranking si es que existe 
        /// alguno y deshabilita los botones 
        /// </summary>
        public Tablero_Principal()
        {
            InitializeComponent();
            HabilitarBotones(false);
            comienzo = false;
            juego = new Juego();
            jugador = new Jugador();
            ranking = new Ranking();
            serializarRanking = new SerializarRanking();
            ranking = serializarRanking.Deserializador();
            nuevoJuegoToolStripMenuItem.Enabled = false;
        }
        
        /// <summary>
        /// Inicializa los parámetros más importantes para que se puedan visualizar en pantalla
        /// además crear los manejadores de eventos con sus respectivos métodos a disparar
        /// </summary>
        /// <param name="nombre">Recibe el nombre del jugador ingresado por el usuario</param>
        /// <param name="fichas">Recibe la cantidad de fichas iniciales ingresado por el usuario</param>
        public void Inicializador(string nombre, int fichas)
        {
            jugador.NombreJugador = nombre;
            textBoxNombreUser.Text = jugador.NombreJugador;

            jugador.NumeroFichasInicial = fichas;
            jugador.NumeroFichasActual = fichas;
            textBoxMisFichas.Text = jugador.NumeroFichasInicial.ToString();
            juego.actualizoFichas += new Juego.ActualizarFichasEventHandler(EstadoDelPozo);
            juego.verJugada += new Juego.VerJugadaEventHandler(EstadoDeJugada);
            jugador.avisoFichas += new Jugador.AvisoFichasEventHandler(EstadoDeFichas);
        }
        #endregion

        #region Métodos activados por eventos
        /// <summary>
        /// Con este método puedo observar que me quedé sin fichas dando un mensaje en pantalla,
        /// deshbilitando los botones y haciendo que el jugador pierda el turno
        /// </summary>
        /// <param name="mensaje">Recibo un mensaje de que se quedo sin fichas</param>
        virtual public void EstadoDeFichas(string mensaje)
        {
            MessageBox.Show(mensaje, "Fichas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelMensaje1.Text = "Lo sentimos!!!";
            labelMensaje2.Text = "No podrá continuar";
            finalizarJuegoToolStripMenuItem.Enabled = false;
            HabilitarBotones(false);
            jugador.VerResultado();
            ranking.Agregar(jugador);
            serializarRanking.Serializador(ranking);
        }

        /// <summary>
        /// Con este método puedo ver el estado de la jugada y habilito o deshabilito botones
        /// además de indicar si es el turno o no del jugador de acuerdo al índice
        /// </summary>
        /// <param name="indice">Me indica el estado de la jugada</param>
        public void EstadoDeJugada(int indice)
        {
            if (indice == 7)
            {
                juego.EstadoDelPozo("viborita");
                labelMensaje1.Text = "Has caido en la viborita!!!";
                labelMensaje2.Text = "Pierdes una ficha y el turno.";
                timerPausa.Start();
                jugador.Turno = -1;
                HabilitarBotones(false);
            }
            if (indice == 1)
            {
                juego.EstadoDelPozo("sinpozo");
                labelMensaje1.Text = "Felicidades, salieron tus números!!!";
                labelMensaje2.Text = "Te puedes llevar lo del pozo";
                timerPausa.Start();
                jugador.Turno = 1;
                HabilitarBotones(true);
            }
            if (indice == -1)
            {
                labelMensaje1.Text = "Lo siento, no salieron tus números.";
                labelMensaje2.Text = "Pierdes tu turno.";
                jugador.Turno = -1;
                timerPausa.Start();
                HabilitarBotones(false);
            }
            if (indice == 0)
            {
                labelMensaje1.Text = "Dados iguales!!!";
                labelMensaje2.Text = "Puedes tirar nuevamente los dados.";
                jugador.Turno = 1;
                timerPausa.Start();
                HabilitarBotones(false, true);
            }
            textBoxPozo.Text = juego.Pozo.ToString();
        }

        /// <summary>
        /// Con este método puedo actualizar las fichas del adversario según el estado
        /// del pozo ya sea que se deban restar si cayó en la viborita o se deban sumar 
        /// si salió el número elegido
        /// </summary>
        /// <param name="resultado">Es el resultado de la jugada -1 si pierde fichas y 1 se gana</param>
        /// <param name="pozo">Es la cantidad de fichas del pozo, por defecto se pasa 0</param>
        public void EstadoDelPozo(int resultado, int pozo = 0)
        {
            jugador.ManejoDeFichas(resultado, pozo);
            textBoxMisFichas.Text = jugador.NumeroFichasActual.ToString();
        }
        #endregion

        #region Métodos con efecto visual
        /// <summary>
        /// Habilita o deshabilita los botones en función de la jugada
        /// </summary>
        /// <param name="hab_num">Booleano para habilitar o no al panel de números</param>
        /// <param name="hab_cubilete">Booleano para habilitar o no el cubilete</param>
        public void HabilitarBotones(bool hab_num, bool hab_cubilete = false)
        {
            foreach (Button btn in Controls.OfType<Button>())
            {
                if (btn.Tag.ToString() == "num")
                {
                    btn.Enabled = hab_num;
                }
                if (btn.Tag.ToString() == "cubilete")
                {
                    btn.Enabled = hab_cubilete;
                }
            }
        }        

        /// <summary>
        /// Permite visualizar un efecto de cambio de color en los botones de números cuando
        /// el mouse se aleja de los mismos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonNumberHover(object sender, EventArgs e)
        {
            if(((Button)sender).Tag.ToString() == "num")
            {
                ((Button)sender).BackgroundImage = Properties.Resources.button_numero_activado;
            }
        }

        /// <summary>
        /// Permite visualizar un efecto de cambio de color en los botones de números cuando
        /// el mouse se acerca a los mismos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonNumberLeave(object sender, EventArgs e)
        {
            if (((Button)sender).Tag.ToString() == "num")
            {
                ((Button)sender).BackgroundImage = Properties.Resources.button_numero_desactivado;
            }
        }

        /// <summary>
        /// Elige la imagen del dado en función a los números salidos en la jugada
        /// </summary>
        public void NumeroDeDados()
        {
            switch (juego.NumDado1)
            {
                case 1:
                    pictureBoxDado1.BackgroundImage = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureBoxDado1.BackgroundImage = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureBoxDado1.BackgroundImage = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureBoxDado1.BackgroundImage = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureBoxDado1.BackgroundImage = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureBoxDado1.BackgroundImage = Properties.Resources.dado6;
                    break;
            }
            switch (juego.NumDado2)
            {
                case 1:
                    pictureBoxDado2.BackgroundImage = Properties.Resources.dado1;
                    break;
                case 2:
                    pictureBoxDado2.BackgroundImage = Properties.Resources.dado2;
                    break;
                case 3:
                    pictureBoxDado2.BackgroundImage = Properties.Resources.dado3;
                    break;
                case 4:
                    pictureBoxDado2.BackgroundImage = Properties.Resources.dado4;
                    break;
                case 5:
                    pictureBoxDado2.BackgroundImage = Properties.Resources.dado5;
                    break;
                case 6:
                    pictureBoxDado2.BackgroundImage = Properties.Resources.dado6;
                    break;
            }
        }

        /// <summary>
        /// Borra las imagenes de los dados en pantalla
        /// </summary>
        public void BorrarDados()
        {
            pictureBoxDado1.BackgroundImage = null;
            pictureBoxDado2.BackgroundImage = null;
        }

        /// <summary>
        /// Da el mensaje en pantalla de acuerdo al turno del jugador
        /// </summary>
        public void MensajesTurno()
        {
            if (jugador.Turno == 1)
            {
                labelMensaje1.Text = "Es tu turno!";
                labelMensaje2.Text = "Elige un número...";
            }
            else if (jugador.Turno == -1)
            {
                labelMensaje1.Text = "Es el turno de tu adversario!";
                labelMensaje2.Text = "Deberas esperar...";
            }
        }

        /// <summary>
        /// Da un mensaje si el adversario ha abandonado o no la partida
        /// </summary>
        public void MensajeAbandono()
        {
            labelMensaje1.Text = "Tu adversario ha abandonado!";
            labelMensaje2.Text = "Puedes abandonar o plantarse";
        }

        /// <summary>
        /// Da un mensaje si el adversario se ha quedado sin fichas
        /// </summary>
        public void MensajeSinFichas()
        {
            labelMensaje1.Text = "Tu adversario se quedó sin fichas!";
            labelMensaje2.Text = "Puedes abandonar o plantarse";
        }

        /// <summary>
        /// Este método se dispara cuando se inicia el formulario para ocultar el tablero
        /// principal y mostrar el de conexión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableroPrincipal_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region MenuStrip
        /// <summary>
        /// Muestra el tablero de información del programa con su autor y la versión del mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acercaDelJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablero_Informacion tableroInformacion = new Tablero_Informacion();
            tableroInformacion.Show();
        }

        /// <summary>
        /// Permite empezar la partida a los jugadores deshabilitandose así mismo y dandole lugar
        /// a la variable comienzo como true 
        /// (Su implementación más específicas están en las clases hijas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual public void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoJuegoToolStripMenuItem.Enabled = false;
            comienzo = true;
        }

        /// <summary>
        /// Manodo un mensaje si no es el turno del usuario para que no pueda plantarse y deba
        /// esperar
        /// (Su implementación más específicas están en las clases hijas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual public void finalizarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jugador.Turno == -1)
            {
                MessageBox.Show("No es tu turno para salir", "No corresponde", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// (Su implementación más específicas están en las clases hijas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual public void rakingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // La implementación se hace en las clases hijas
        }

        /// <summary>
        /// Abandona el juego de acuerdo al evento del formulario llamado FormClosing forzando
        /// a su método para que la aplicación se cierre
        /// (Su implementación más específicas están en las clases hijas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual public void abandonarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jugador.Turno == -1)
            {
                MessageBox.Show("No es tu turno para salir", "No corresponde", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        /// <summary>
        /// Permite visualizar el apartado de instrucciones para ver como funciona el juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablero_Ayuda tablero_Ayuda = new Tablero_Ayuda();
            tablero_Ayuda.Show();
        }
        #endregion

        #region Botones en juego
        /// <summary>
        /// Cuando se hace click a alguno de los números este pasa habilitar al cubilete para que se 
        /// pueda a interactuar con el mismo y además guarda dicho número en la variable del objeto juego
        /// (Su implementación más específicas están en las clases hijas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual public void ClickNumeroElegido(object sender, EventArgs e)
        {
            string numElegido = ((Button)sender).Text;
            textBoxNumElegido.Text = numElegido;
            juego.NumeroElegido = int.Parse(numElegido);
            HabilitarBotones(false,true);
            MessageBox.Show("Ya has elegido un número. Ahora has click en el cubilete para tirar los dados.", "Numero elegido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Cuando se hace click al cubilete se llama a la función TirarDados y se verifica la jugada
        /// en la clase juego. Además se llama a la función NumeroDeDados() para mostrar los dados en
        /// pantalla y activar el timer para borrarlos luego de un tiempo
        /// (Su implementación más específicas están en las clases hijas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual public void ClickCubilete(object sender, EventArgs e)
        {
            int resultadoDados = juego.TirarDados();
            NumeroDeDados();
            juego.Jugada(juego.NumeroElegido, resultadoDados);
            timerDados.Start();
        }
        #endregion

        #region Timers
        // Contadores para los timer
        int contTimerDados = 0;
        int contTimerPausa = 0;

        /// <summary>
        /// Este timer es activado luego de tirar los dados para que pasado tres ticks
        /// puedan borrarse los mismo en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDados_Tick(object sender, EventArgs e)
        {
            if (contTimerDados == 3)
            {
                BorrarDados();
                contTimerDados = 0;
                timerDados.Stop();
            }
            else
            {
                contTimerDados++;
            }
        }

        /// <summary>
        /// Este timer es activado cuando aparece un mensaje de la jugada en pantalla
        /// y pasado 5 ticks borra estos mensajes y pone el del turno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPausa_Tick(object sender, EventArgs e)
        {
            if (contTimerPausa == 5)
            {
                MensajesTurno();
                contTimerPausa = 0;
                timerPausa.Stop();
            }
            else
            {
                contTimerPausa++;
            }
        }
        #endregion

        #region Actualización y selección de turnos
        /// <summary>
        /// Esta función es quizá una de las más importante porque permite actualizar los
        /// campos de los usuarios rivales de acuerdo a la jugada. Por lo tanto no solo 
        /// actualiza los TextBox sino también las variables de los objetos juego y jugador
        /// </summary>
        /// <param name="game">Recibo el objeto juego enviado por el cliente o el servidor</param>
        /// <param name="player">Recibo el objeto jugador enviado por el cliente o el servidor</param>
        public void ActualizarCampos(Juego game, Jugador player)
        {
            if(jugador.NombreAdversario == "")
            {
                nuevoJuegoToolStripMenuItem.Enabled = true;
                jugador.NombreAdversario = player.NombreJugador;
                textBoxNombreAdv.Text = jugador.NombreAdversario.ToString();
            }

            juego.NumeroElegido = game.NumeroElegido;
            if(juego.NumeroElegido != 1)
            {
                textBoxNumElegido.Text = juego.NumeroElegido.ToString();
            }
            
            jugador.NumeroFichasAdversario = player.NumeroFichasActual;
            textBoxFichasAdv.Text = jugador.NumeroFichasAdversario.ToString();

            jugador.RetiradaAdversario = player.Retirada;

            juego.Pozo = game.Pozo;
            textBoxPozo.Text = juego.Pozo.ToString();
            juego.NumDado1 = game.NumDado1;
            juego.NumDado2 = game.NumDado2;

            if (juego.NumDado1 != 0 && juego.NumDado2 != 0)
            {
                NumeroDeDados();
                timerDados.Start();
            }
        }

        /// <summary>
        /// Este método me permite determinar el turno inicial de acuerdo a la cantidad
        /// de fichas de los jugadores, el que haya empezado con mayor fichas será el primero
        /// (Su implementación más específica está en las clases hijas)
        /// </summary>
        virtual public void DeterminarTurnoInicial()
        {
            if (jugador.NumeroFichasActual > jugador.NumeroFichasAdversario)
            {
                jugador.Turno = 1;
            }
            else if (jugador.NumeroFichasActual < jugador.NumeroFichasAdversario)
            {
                jugador.Turno = -1;
            }
        }
        #endregion

        #region Cerrar formulario
        /// <summary>
        /// Este método tiene lugar cuando se está cerrando el formulario. Si no es el 
        /// turno del jugador se mandará un mensaje advirtiendole. Pero si el turno y
        /// todavía no comenzó entonces`puede cerrar la aplicación
        /// (Su implementación más específica está en las clases hijas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual public void Tablero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (jugador.Turno == -1)
            {
                MessageBox.Show("No es tu turno para salir", "No corresponde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            if (jugador.Turno == 1 || !comienzo)
            {
                salir = MessageBox.Show("¿Quieres salir del juego?", "Salir del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (DialogResult.No == salir)
                {
                    e.Cancel = true;
                }
                else if (DialogResult.Yes == salir && !comienzo)
                {
                    e.Cancel = false;
                    Application.ExitThread();
                    //Application.Exit();
                }
            }
        }
        #endregion
    }
}
