using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using LogicaDelJuego;

namespace LogicaAsincrona
{
    /// <summary>
    /// Esta clase serializa lo que posee en su buffer y lo envía por medio de sockets
    /// </summary>
    [Serializable]
    public class Serializador
    {
        #region Atributos (algunos ya instanciados)
        [NonSerialized]
        public Socket Socket;
        [NonSerialized]
        public List<byte> TransmisionBuffer = new List<byte>();
        [NonSerialized]
        public byte[] buffer = new byte[1024];
        
        public GuardarJuego guardarJuego = new GuardarJuego();
        #endregion

        #region Serializar
        /// <summary>
        /// Serializa en formato Soap lo que está en el buffer de esta clase
        /// </summary>
        /// <returns>Devuelve un arreglo de bytes de la información en el buffer</returns>
        public byte[] Serializar()
        {
            SoapFormatter formatter = new SoapFormatter();
            MemoryStream mem = new MemoryStream();
            formatter.Serialize(mem, this);
            return mem.GetBuffer();
        }
        #endregion

        #region Deserializar
        /// <summary>
        /// Deserializa la información recibida escribiendo el Buffer
        /// </summary>
        /// <returns>Retorna un objeto de tipo Serializador</returns>
        public Serializador Deserializar()
        {
            try
            {
                byte[] datosBuffer = TransmisionBuffer.ToArray();
                SoapFormatter formatter = new SoapFormatter();
                MemoryStream mem = new MemoryStream();
                mem.Write(datosBuffer, 0, datosBuffer.Length);
                mem.Seek(0, 0);
                return (Serializador)formatter.Deserialize(mem);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("\n\nFallo la deserializacion. Razón: " + e.Message);
                return null;
            }
        }
        #endregion
    }
}
