using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDelJuego
{
    [Serializable]
    public class Ranking
    {
        #region Atributo
        private ArrayList lista;
        #endregion

        #region Método get
        /// <summary>
        /// Método get
        /// </summary>
        public ArrayList Lista
        {
            get { return lista; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Ranking()
        {
            lista = new ArrayList();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Agrego un jugador dentro de un arreglo de jugadores y lo ordeno
        /// </summary>
        /// <param name="jugador">Es el jugador que se va a agregar</param>
        public void Agregar(Jugador jugador)
        {
            lista.Add(jugador);
            Ordenar();
        }

        /// <summary>
        /// Ordena la lista de acuerdo al CompareTo del la clase Jugador
        /// </summary>
        private void Ordenar()
        {
            lista.Sort();
        }

        /// <summary>
        /// Puedo observar el nombre de los jugadores de la lisra
        /// </summary>
        public void Mostrar()
        {
            foreach(Jugador jug in lista)
            {
                Console.WriteLine("\nNombre jugador en lista {0}",jug.NombreJugador);
            }
        }

        /// <summary>
        /// Obtengo la cantidad de items en la lista
        /// </summary>
        /// <returns>Devuelvo la cantidad de items</returns>
        public int Cantidad()
        {
            return lista.Count;
        }
        #endregion
    }
}
