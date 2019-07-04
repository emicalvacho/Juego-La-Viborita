using System;
using System.IO;
using System.Xml.Serialization;

namespace LogicaDelJuego
{
    /// <summary>
    /// Esta clase me permite serializar el ranking para poder almacenarlo y obtenerlo cuando
    /// sea necesario
    /// </summary>
    public class SerializarRanking
    {
        #region Atributo
        private string nombreArchivo;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public SerializarRanking()
        {
            nombreArchivo = "Ranking.xml";
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Me permite serializar el objeto de tipo ranking en XML
        /// </summary>
        /// <param name="objeto">Recibo un objeto de tipo ranking</param>
        public void Serializador(Ranking objeto)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Ranking), new Type[] { typeof(Jugador) });
            Stream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, objeto);
            stream.Close();
        }

        /// <summary>
        /// Me permite deserializar un objeto y serializarlo en el caso que este no exista como XML
        /// </summary>
        /// <returns>Devuelvo el ranking deserializado</returns>
        public Ranking Deserializador()
        {
            Ranking objeto = new Ranking();
            XmlSerializer formatter = new XmlSerializer(typeof(Ranking), new Type[] { typeof(Jugador) });
            try
            {
                Stream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.Read);
                objeto = (Ranking)formatter.Deserialize(stream);
                stream.Close();
                return objeto;
            }
            catch (Exception)
            {
                Serializador(objeto);
                return objeto;
            }
        }
        #endregion
    }
}
