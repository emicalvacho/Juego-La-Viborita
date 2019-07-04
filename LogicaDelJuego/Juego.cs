using System;

namespace LogicaDelJuego
{
    /// <summary>
    /// Esta clase permite controlar la dinámica del juego haciendo uso de los elementos
    /// como los dados y el cubilete y verificando el estado de la jugada
    /// </summary>
    [Serializable]
    public class Juego
    {
        #region Delegados y Eventos
        // El evento se disparará cuando se vea el resultado de los dados
        public delegate void VerJugadaEventHandler(int resultado);
        public event VerJugadaEventHandler verJugada;

        // El evento se disparará cuando se cambie el estado del pozo
        public delegate void ActualizarFichasEventHandler(int resultado, int pozo=0);
        public event ActualizarFichasEventHandler actualizoFichas;
        #endregion

        #region Atributos
        private int numDado1;
        private int numDado2;
        private int pozo;
        private string resultadoDeJugada;
        private int numeroElegido;
        #endregion

        #region Métodos Get y Set
        /// <summary>
        /// Obtengo y configuro el numero del dado 1
        /// </summary>
        public int NumDado1
        {
            get { return numDado1; }
            set { numDado1 = value; }
        }

        /// <summary>
        /// Obtengo y configuro el numero del dado 2
        /// </summary>
        public int NumDado2
        {
            get { return numDado2; }
            set { numDado2 = value; }
        }

        /// <summary>
        /// Obtengo y configuro el pozo
        /// </summary>
        public int Pozo
        {
            get { return pozo; }
            set
            {
                if (value < 0)
                    throw new Exception("El valor del pozo es negativo");
                else
                    pozo = value;
            }
        }

        /// <summary>
        /// Obtengo y configuro el numero elegido
        /// </summary>
        public int NumeroElegido
        {
            get { return numeroElegido; }
            set
            {
                if (value == 7 || value > 12 || value < 1)
                    throw new Exception("Numero elegido no valido");
                else
                    numeroElegido = value;
            }
        }

        /// <summary>
        /// Obtengo y configuro el resultado de la jugada
        /// </summary>
        public string ResultadoDeJugada { get => resultadoDeJugada; set => resultadoDeJugada = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que inicializa los atributos
        /// </summary>
        public Juego()
        {
            NumDado1 = 0;
            NumDado2 = 0;
            Pozo = 2;
            ResultadoDeJugada = "";
            NumeroElegido = 1;
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Realiza un random de dos números aleatorios para la tirada de dados
        /// </summary>
        /// <returns>Se devuelve la suma de los números de los dados</returns>
        public int TirarDados()
        {
            int sumaDados = 0;

            Random numeroAleatorio = new Random();

            NumDado1 = numeroAleatorio.Next(1, 7);
            NumDado2 = numeroAleatorio.Next(1, 7);

            sumaDados = NumDado1 + NumDado2;

            return sumaDados;
        }

        /// <summary>
        /// De acuerdo a los dados tirados se revisa la jugada con un respectivo índice
        /// </summary>
        /// <param name="numeroElegido">Es el numero elegido por el jugador</param>
        /// <param name="resultado">Es el resultado de la suma de los dados</param>
        /// <returns>Se devuelve el estado de la jugada</returns>
        public int Jugada(int numeroElegido, int resultado)
        {
            if(numeroElegido == resultado)
            {
                verJugada(1);
                return 1;
            }
            else if(resultado == 7)
            {
                verJugada(7);
                return 7;
            }
            else if(NumDado1 == NumDado2)
            {
                verJugada(0);
                return 0;
            }
            verJugada(-1);
            return -1;
        }

        /// <summary>
        /// Puedo ver el estado del pozo de acuerdo a la jugada y actualizar tanto las 
        /// fichas del pozo como las del jugador
        /// </summary>
        /// <param name="resultado">Obtengo un string con el tipo de resultado</param>
        public void EstadoDelPozo(string resultado)
        {
            if(resultado == "viborita")
            {
                resultadoDeJugada = "viborita";
                actualizoFichas(-1);
                Pozo ++;
            }
            else if(resultado == "sinpozo")
            {
                resultadoDeJugada = "ganado";
                actualizoFichas(1,Pozo);
                Pozo = 2;
            }
        }
        #endregion
    }
}
