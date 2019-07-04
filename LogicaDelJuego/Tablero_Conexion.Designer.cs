namespace LogicaDelJuego
{
    partial class Tablero_Conexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero_Conexion));
            this.buttonJugar = new System.Windows.Forms.Button();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.pictureBoxDados = new System.Windows.Forms.PictureBox();
            this.textBoxFichasIniciales = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFichasIniciales = new System.Windows.Forms.Label();
            this.labelFichasMInMax = new System.Windows.Forms.Label();
            this.labelConfiguracionInicial = new System.Windows.Forms.Label();
            this.errorProviderFaltaCompletar = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonInformacion = new System.Windows.Forms.Button();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.labelDirIP = new System.Windows.Forms.Label();
            this.labelEjemploIP = new System.Windows.Forms.Label();
            this.textBoxDirIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFaltaCompletar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJugar
            // 
            this.buttonJugar.BackgroundImage = global::LogicaDelJuego.Properties.Resources.botones_conexion;
            this.buttonJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJugar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonJugar.FlatAppearance.BorderSize = 2;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJugar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonJugar.Location = new System.Drawing.Point(537, 280);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(176, 63);
            this.buttonJugar.TabIndex = 5;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(63, 126);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(318, 29);
            this.textBoxNombreUsuario.TabIndex = 7;
            this.textBoxNombreUsuario.Tag = "Nombre de Usuario";
            // 
            // pictureBoxDados
            // 
            this.pictureBoxDados.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDados.BackgroundImage = global::LogicaDelJuego.Properties.Resources.dados_presentacion;
            this.pictureBoxDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDados.Location = new System.Drawing.Point(451, 20);
            this.pictureBoxDados.Name = "pictureBoxDados";
            this.pictureBoxDados.Size = new System.Drawing.Size(336, 229);
            this.pictureBoxDados.TabIndex = 8;
            this.pictureBoxDados.TabStop = false;
            // 
            // textBoxFichasIniciales
            // 
            this.textBoxFichasIniciales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxFichasIniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFichasIniciales.Location = new System.Drawing.Point(63, 220);
            this.textBoxFichasIniciales.Name = "textBoxFichasIniciales";
            this.textBoxFichasIniciales.Size = new System.Drawing.Size(83, 29);
            this.textBoxFichasIniciales.TabIndex = 10;
            this.textBoxFichasIniciales.Tag = "Fichas Iniciales";
            this.textBoxFichasIniciales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNombre.Location = new System.Drawing.Point(34, 89);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(292, 34);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Text = "- Nombre de Usuario:";
            // 
            // labelFichasIniciales
            // 
            this.labelFichasIniciales.AutoSize = true;
            this.labelFichasIniciales.BackColor = System.Drawing.Color.Transparent;
            this.labelFichasIniciales.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichasIniciales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelFichasIniciales.Location = new System.Drawing.Point(34, 179);
            this.labelFichasIniciales.Name = "labelFichasIniciales";
            this.labelFichasIniciales.Size = new System.Drawing.Size(226, 34);
            this.labelFichasIniciales.TabIndex = 13;
            this.labelFichasIniciales.Text = "- Fichas iniciales:";
            // 
            // labelFichasMInMax
            // 
            this.labelFichasMInMax.AutoSize = true;
            this.labelFichasMInMax.BackColor = System.Drawing.Color.Transparent;
            this.labelFichasMInMax.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichasMInMax.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelFichasMInMax.Location = new System.Drawing.Point(204, 222);
            this.labelFichasMInMax.Name = "labelFichasMInMax";
            this.labelFichasMInMax.Size = new System.Drawing.Size(177, 25);
            this.labelFichasMInMax.TabIndex = 14;
            this.labelFichasMInMax.Text = "(Min:1 - Max:20)";
            // 
            // labelConfiguracionInicial
            // 
            this.labelConfiguracionInicial.AutoSize = true;
            this.labelConfiguracionInicial.BackColor = System.Drawing.Color.Transparent;
            this.labelConfiguracionInicial.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguracionInicial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelConfiguracionInicial.Location = new System.Drawing.Point(33, 20);
            this.labelConfiguracionInicial.Name = "labelConfiguracionInicial";
            this.labelConfiguracionInicial.Size = new System.Drawing.Size(331, 41);
            this.labelConfiguracionInicial.TabIndex = 15;
            this.labelConfiguracionInicial.Text = "Configuración Inicial";
            // 
            // errorProviderFaltaCompletar
            // 
            this.errorProviderFaltaCompletar.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFaltaCompletar.ContainerControl = this;
            this.errorProviderFaltaCompletar.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderFaltaCompletar.Icon")));
            // 
            // buttonInformacion
            // 
            this.buttonInformacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInformacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacion.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformacion.ForeColor = System.Drawing.Color.White;
            this.buttonInformacion.Location = new System.Drawing.Point(737, 20);
            this.buttonInformacion.Name = "buttonInformacion";
            this.buttonInformacion.Size = new System.Drawing.Size(50, 50);
            this.buttonInformacion.TabIndex = 16;
            this.buttonInformacion.Text = "i";
            this.buttonInformacion.UseVisualStyleBackColor = false;
            this.buttonInformacion.Click += new System.EventHandler(this.buttonInformacion_Click);
            // 
            // buttonRanking
            // 
            this.buttonRanking.BackgroundImage = global::LogicaDelJuego.Properties.Resources.botones_conexion;
            this.buttonRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRanking.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRanking.FlatAppearance.BorderSize = 2;
            this.buttonRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRanking.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRanking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRanking.Location = new System.Drawing.Point(549, 363);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Size = new System.Drawing.Size(150, 50);
            this.buttonRanking.TabIndex = 17;
            this.buttonRanking.Text = "Ranking";
            this.buttonRanking.UseVisualStyleBackColor = false;
            this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
            // 
            // labelDirIP
            // 
            this.labelDirIP.AutoSize = true;
            this.labelDirIP.BackColor = System.Drawing.Color.Transparent;
            this.labelDirIP.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirIP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDirIP.Location = new System.Drawing.Point(34, 268);
            this.labelDirIP.Name = "labelDirIP";
            this.labelDirIP.Size = new System.Drawing.Size(198, 34);
            this.labelDirIP.TabIndex = 18;
            this.labelDirIP.Text = "- Dirección IP:";
            // 
            // labelEjemploIP
            // 
            this.labelEjemploIP.AutoSize = true;
            this.labelEjemploIP.BackColor = System.Drawing.Color.Transparent;
            this.labelEjemploIP.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjemploIP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelEjemploIP.Location = new System.Drawing.Point(307, 314);
            this.labelEjemploIP.Name = "labelEjemploIP";
            this.labelEjemploIP.Size = new System.Drawing.Size(174, 25);
            this.labelEjemploIP.TabIndex = 19;
            this.labelEjemploIP.Text = "(Ej 192.168.1.10)";
            // 
            // textBoxDirIP
            // 
            this.textBoxDirIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDirIP.Enabled = false;
            this.textBoxDirIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirIP.Location = new System.Drawing.Point(63, 314);
            this.textBoxDirIP.Name = "textBoxDirIP";
            this.textBoxDirIP.Size = new System.Drawing.Size(197, 29);
            this.textBoxDirIP.TabIndex = 20;
            this.textBoxDirIP.Tag = "ip";
            // 
            // Tablero_Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fondo_configuracion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 436);
            this.Controls.Add(this.textBoxDirIP);
            this.Controls.Add(this.labelEjemploIP);
            this.Controls.Add(this.labelDirIP);
            this.Controls.Add(this.buttonRanking);
            this.Controls.Add(this.buttonInformacion);
            this.Controls.Add(this.labelConfiguracionInicial);
            this.Controls.Add(this.labelFichasMInMax);
            this.Controls.Add(this.labelFichasIniciales);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxFichasIniciales);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.pictureBoxDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 475);
            this.MinimumSize = new System.Drawing.Size(815, 475);
            this.Name = "Tablero_Conexion";
            this.Text = "La Viborita";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tablero_Conexion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFaltaCompletar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonJugar;
        public System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.Label labelFichasIniciales;
        public System.Windows.Forms.Label labelFichasMInMax;
        public System.Windows.Forms.Label labelConfiguracionInicial;
        public System.Windows.Forms.TextBox textBoxNombreUsuario;
        public System.Windows.Forms.PictureBox pictureBoxDados;
        public System.Windows.Forms.ErrorProvider errorProviderFaltaCompletar;
        protected System.Windows.Forms.TextBox textBoxFichasIniciales;
        public System.Windows.Forms.Button buttonRanking;
        public System.Windows.Forms.Button buttonInformacion;
        protected System.Windows.Forms.TextBox textBoxDirIP;
        public System.Windows.Forms.Label labelEjemploIP;
        public System.Windows.Forms.Label labelDirIP;
    }
}