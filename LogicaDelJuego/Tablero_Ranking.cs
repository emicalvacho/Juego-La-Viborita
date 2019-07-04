using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDelJuego
{
    /// <summary>
    /// Este formulario permite visualizar el listado de los 5 mejores jugadores 
    /// de acuerdo a su equipo y ordenados según la diferencias de fichas
    /// </summary>
    public partial class Tablero_Ranking : Form
    {
        #region Atributos
        SerializarRanking serializarRanking;
        Ranking ranking;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que inicializa los atributos
        /// </summary>
        /// <param name="equipo">Es el nombre del equipo actual según el formulario</param>
        public Tablero_Ranking(string equipo)
        {
            serializarRanking = new SerializarRanking();
            ranking = new Ranking();
            ranking = serializarRanking.Deserializador();
            InitializeComponent();
            Text = "Ranking " + equipo;
        }
        #endregion

        #region Load
        /// <summary>
        /// Evento que se dispara cuando se carga el formulario y permite visualizar
        /// al listado de jugadores según el equipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tablero_Ranking_Load(object sender, EventArgs e)
        {
            if (ranking.Cantidad() > 0)
            {
                for (int i = 0; i < ranking.Cantidad(); i++)
                {
                    if (i == 5)
                    {
                        break;
                    }
                    foreach (TextBox txt in Controls.OfType<TextBox>())
                    {
                        if (txt.Tag.ToString() == ("nom" + (i + 1).ToString()))
                        {
                            txt.Text = ((Jugador)ranking.Lista[i]).NombreJugador;
                        }
                        if (txt.Tag.ToString() == ("dif" + (i + 1).ToString()))
                        {
                            txt.Text = ((Jugador)ranking.Lista[i]).Diferencia.ToString();
                        }
                        if (txt.Tag.ToString() == ("res" + (i + 1).ToString()))
                        {
                            txt.Text = ((Jugador)ranking.Lista[i]).ResultadoPartida;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay jugadores listados");
            }  
        }
        #endregion
    }
}
