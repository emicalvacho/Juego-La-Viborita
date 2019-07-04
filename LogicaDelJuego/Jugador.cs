using System;

namespace LogicaDelJuego
{
    /// <summary>
    /// Esta clase le permite al jugador moverse en el juego con sus respectivos
    /// atributos y funciones
    /// </summary>
    [Serializable]
    public class Jugador : IComparable
    {
        #region Delegado y evento
        // Permite avisarle al usuario que se quedó sin fichas
        public delegate void AvisoFichasEventHandler(string mensaje);
        public event AvisoFichasEventHandler avisoFichas;
        #endregion

        #region Atributos
        private int numeroFichasInicial;
        private int numeroFichasActual;
        private string nombreJugador;
        private string nombreAdversario;
        private bool retirada;
        private int turno;
        private int numeroFichasAdversario;
        private int diferencia;
        private string resultadoPartida;
        private bool retiradaAdversario;
        private bool sinFichasAdversario;
        #endregion

        #region Métodos get y set
        /// <summary>
        /// Obtengo y configuro las fichas iniciales
        /// </summary>
        public int NumeroFichasInicial
        {
            get { return numeroFichasInicial; }
            set
            {
                if (value < 1)
                    throw new Exception("El numero de fichas debe ser al menos mayor a 1.");
                else
                    numeroFichasInicial = value;
            }
        }

        /// <summary>
        /// Obtengo y configuro las fichas actuales
        /// </summary>
        public int NumeroFichasActual
        {
            get { return numeroFichasActual; }
            set
            {
                if (value < 0)
                    throw new Exception("Se ha quedado sin fichas.");
                else
                    numeroFichasActual = value;
            }
        }

        /// <summary>
        /// Obtengo y configuro el nombre del jugador
        /// </summary>
        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }

        /// <summary>
        /// Obtengo y configuro el turno del jugador
        /// </summary>
        public int Turno { get => turno; set => turno = value; }

        /// <summary>
        /// Obtengo y configuro las fichas del adversario
        /// </summary>
        public int NumeroFichasAdversario { get => numeroFichasAdversario; set => numeroFichasAdversario = value; }

        /// <summary>
        /// Obtengo y configuro el nombre del adversario
        /// </summary>
        public string NombreAdversario { get => nombreAdversario; set => nombreAdversario = value; }

        /// <summary>
        /// Obtengo y configuro la diferencia
        /// </summary>
        public int Diferencia { get => diferencia; set => diferencia = value; }

        /// <summary>
        /// Obtengo y configuro si el adversario se retiro o no
        /// </summary>
        public bool RetiradaAdversario { get => retiradaAdversario; set => retiradaAdversario = value; }

        /// <summary>
        /// Obtengo y configuro el resultado de la partida para el ranking
        /// </summary>
        public string ResultadoPartida { get => resultadoPartida; set => resultadoPartida = value; }

        /// <summary>
        /// Obtengo y configuro la retirada del jugador
        /// </summary>
        public bool Retirada { get => retirada; set => retirada = value; }

        /// <summary>
        /// Obtengo y configuro si el jugador se quedó sin fichas
        /// </summary>
        public bool SinFichasAdversario { get => sinFichasAdversario; set => sinFichasAdversario = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que inicializa los atributos
        /// </summary>
        public Jugador()
        {
            NumeroFichasInicial = 1;
            NumeroFichasActual = 0;
            Retirada = false;
            NombreJugador = "";
            Turno = 0;
            NombreAdversario = "";
            NumeroFichasAdversario = 0;
            Diferencia = 0;
            RetiradaAdversario = false;
            SinFichasAdversario = false;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// El manejo de fichas me permite actualizar las fichas del usuario de acuerdo a la jugada.
        /// Disparará un evento de que el jugador se ha quedado sin fichas si fuera el caso
        /// </summary>
        /// <param name="resultado">Es el resultado de la jugada i perdió -1 y si ganó 1</param>
        /// <param name="pozo">Es el pozo acumulado en la partida</param>
        public void ManejoDeFichas(int resultado, int pozo)
        {
            if (NumeroFichasActual > 0)
            {
                if (resultado == -1)
                {
                    NumeroFichasActual--;
                }
                if (resultado == 1)
                {
                    NumeroFichasActual += pozo;
                }
            }
            if (NumeroFichasActual == 0) 
            {
                SinFichasAdversario = true;
                avisoFichas("Se ha quedado SIN fichas");
            }
        }
        
        /// <summary>
        /// De acuerdo a la diferencia entre las fichas actuales con las iniciales
        /// reviso si el jugador salió ganando, perdiendo o hecho para ponerlo en 
        /// el ranking
        /// </summary>
        public void VerResultado()
        {
            Diferencia = NumeroFichasActual - NumeroFichasInicial;
            if (Diferencia > 0)
            {
                ResultadoPartida = "Ganancia";
            }
            else if (Diferencia < 0)
            {
                ResultadoPartida = "Pérdida";
            }
            else
            {
                ResultadoPartida = "Hecho";
            }
        }

        /// <summary>
        /// Permite comparar los jugadores entre sí de acuerdo a las diferencias, 
        /// en el caso de empatar se revisa la cantidad de fichas iniciales
        /// </summary>
        /// <param name="obj">Es un objeto de tipo Jugador</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Jugador aux = new Jugador();
            aux = (Jugador)obj;

            if (Diferencia > aux.Diferencia)
            {
                return -1;
            }
            else if (Diferencia < aux.Diferencia)
            {
                return 1;
            }
            else
            {
                if(numeroFichasInicial > aux.NumeroFichasInicial)
                {
                    return -1;
                }
                else if(NumeroFichasInicial < aux.NumeroFichasInicial)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion
    }
}
