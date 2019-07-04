using System;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace LogicaDelJuego
{
    /// <summary>
    /// Este es el primer formulario que va a aparecer para que usuario pueda 
    /// ingresar los datos iniciales, además de poder consultar otros formularios
    /// </summary>
    public partial class Tablero_Conexion : Form
    {
        #region Atributos
        int cantidad;
        string equipo;
        #endregion

        #region Delegados y eventos
        // Sirve para pasar la información ingresada por el usuario de un formulario a otro
        public delegate void PasarInformacionEventHandler(string nombre, int fichas);
        public event PasarInformacionEventHandler PasarInformacionJuego;
        // Sirve para cerrar tanto el formulario secundario como el actual
        public delegate void CerrarFormEventHandler(object obj, FormClosingEventArgs e);
        public event CerrarFormEventHandler Cerrar;
        #endregion

        #region Constructor
        /// <summary>
        /// Es el constructor donde se inicializa los parámetros y además pone los 
        /// límites de caracteres para cada textBox
        /// </summary>
        /// <param name="equipo">Recibo el nombre del equipo del tablero para el ranking</param>
        public Tablero_Conexion(string equipo)
        {
            InitializeComponent();
            textBoxNombreUsuario.MaxLength = 14;
            textBoxFichasIniciales.MaxLength = 2;
            textBoxDirIP.MaxLength = 15;
            cantidad = 0;
            this.equipo = equipo;
        }
        #endregion

        #region Controles y validaciones
        /// <summary>
        /// Permite ver si los TextBox están vacios o no y verificar que la cantidad de fichas
        /// no se sobre pase de los límites preestablecidos
        /// </summary>
        public void ControlarTextBox()
        {
            if (!CamposVacios())
            {
                throw new FormatException("Falta completar campos");
            }
            else
            {
                cantidad = Convert.ToInt32(textBoxFichasIniciales.Text);
                if (cantidad < 1 || cantidad > 20)
                {
                    throw new IndexOutOfRangeException("La cantidad de fichas no puede ser menor a 1 ni mayor a 20");
                }
            }
        }

        /// <summary>
        /// Utilizo un error provider paraver que los campos no estén vacios
        /// </summary>
        /// <returns>Devuelvo true o false de acuerdo a si los campos están vacios o no</returns>
        public bool CamposVacios()
        {
            bool control = true;
            foreach(TextBox text in Controls.OfType<TextBox>())
            {
                if(text.Text == "" && text.Tag.ToString() != "ip")
                {
                    errorProviderFaltaCompletar.SetError(text, "Falta" + text.Tag.ToString());
                    control = false;
                }
                else
                {
                    errorProviderFaltaCompletar.SetError(text, "");
                }
            }
            return control;
        }

        /// <summary>
        /// En el textBox de las fichas iniciales controlo que solo se ingrese números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// En el textBox del IP controlo que solo se ingrese números y puntos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDirIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Valido si la IP ingresada tiene el formato correcto
        /// </summary>
        /// <param name="ipString">Recibo la ip en string</param>
        /// <returns>Devuelvo true o false si la IP es válida o no respectivamente</returns>
        public bool ValidarIPv4(string ipString)
        {
            if (string.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        #endregion

        #region Botones
        /// <summary>
        /// En este botón realizo los controles necesarios y si está todo correcto paso
        /// la información al formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonJugar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlarTextBox();
                PasarInformacionJuego(textBoxNombreUsuario.Text, cantidad);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show(ie.Message, "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Puedo observar el formulario de la información del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInformacion_Click(object sender, EventArgs e)
        {
            Tablero_Informacion tablero_Informacion = new Tablero_Informacion();
            tablero_Informacion.Show();
        }

        /// <summary>
        /// Puedo observar el formulario del ranking de los usuarios según el equipo al que pertenecen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRanking_Click(object sender, EventArgs e)
        {
            Tablero_Ranking tablero_Ranking = new Tablero_Ranking(equipo);
            tablero_Ranking.Show();
        }
        #endregion

        #region Cerrar formulario
        /// <summary>
        /// Cierro el formulario actual y el principal mediante un evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tablero_Conexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cerrar(sender, e);
        }
        #endregion
    }
}
