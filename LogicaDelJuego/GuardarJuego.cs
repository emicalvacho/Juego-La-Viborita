using System;

namespace LogicaDelJuego
{
    /// <summary>
    /// Esta clase me permite Guardar la información que luego va a ser enviada
    /// entre los jugadores de acuerdo a la situación de la partida
    /// </summary>
    [Serializable]
    public class GuardarJuego
    {
        #region Atributos
        public Juego juego;
        public Jugador jugador;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public GuardarJuego()
        {
            juego = new Juego();
            jugador = new Jugador();
        }
        #endregion

        #region Método set
        /// <summary>
        /// Se configura los datos recibidos como jugador y juego
        /// </summary>
        /// <param name="game">Es el objeto recibido para setear el objeto juego</param>
        /// <param name="player">Es el objeto recibido para setear el objeto jugador</param>
        public void SetDatos(Juego game, Jugador player)
        {
            juego.NumDado1 = game.NumDado1;
            juego.NumDado2 = game.NumDado2;
            juego.Pozo = game.Pozo;
            juego.NumeroElegido = game.NumeroElegido;
            juego.ResultadoDeJugada = game.ResultadoDeJugada;

            jugador.NombreJugador = player.NombreJugador;
            jugador.Turno = player.Turno;
            jugador.Retirada = player.Retirada;
            jugador.NumeroFichasActual = player.NumeroFichasActual;
        }
        #endregion

        #region Métodos get
        /// <summary>
        /// Obtengo el objeto juego
        /// </summary>
        public Juego Juego
        {
            get { return juego; }
        }

        /// <summary>
        /// Obtengo el objeto jugador
        /// </summary>
        public Jugador Jugador
        {
            get { return jugador; }
        }
        #endregion
    }
}
