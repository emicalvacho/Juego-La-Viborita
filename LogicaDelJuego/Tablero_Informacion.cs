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
    /// Esta clase me permite ver la información del autor y la version del programa
    /// </summary>
    public partial class Tablero_Informacion : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Tablero_Informacion()
        {
            InitializeComponent();
        }
        #endregion

        #region Método para salir
        /// <summary>
        /// Me permite cerrar el formulario haciendo clic en la viborita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxViborita_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Atributos
        // Estos atributos me permiten mover el formulario sin marcos
        bool drag;
        int mousex;
        int mousey;
        #endregion

        #region Métodos para mover sin marcos
        /// <summary>
        /// Mover hacia abajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fondoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        /// <summary>
        /// Mover hacia los lados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fondoLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Left = Cursor.Position.X - mousex;
                Top = Cursor.Position.Y - mousey;
            }
        }

        /// <summary>
        /// Mover hacia arriba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fondoLogin_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion
    }
}
