namespace LogicaDelJuego
{
    partial class Tablero_Informacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero_Informacion));
            this.pictureBoxViborita = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDialogo = new System.Windows.Forms.PictureBox();
            this.labelDialogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViborita)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDialogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxViborita
            // 
            this.pictureBoxViborita.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxViborita.BackgroundImage = global::LogicaDelJuego.Properties.Resources.snake_info;
            this.pictureBoxViborita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxViborita.Location = new System.Drawing.Point(12, 259);
            this.pictureBoxViborita.Name = "pictureBoxViborita";
            this.pictureBoxViborita.Size = new System.Drawing.Size(119, 129);
            this.pictureBoxViborita.TabIndex = 1;
            this.pictureBoxViborita.TabStop = false;
            this.pictureBoxViborita.Click += new System.EventHandler(this.pictureBoxViborita_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(87, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Programa creado por Emiliano Calvacho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(87, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Todos los derechos reservados © 2018 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Juego \"La Viborita\" - Versión 2.0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fondo_label_info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(44, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 115);
            this.panel1.TabIndex = 6;
            // 
            // pictureBoxDialogo
            // 
            this.pictureBoxDialogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDialogo.BackgroundImage = global::LogicaDelJuego.Properties.Resources.burbuja_dialogo;
            this.pictureBoxDialogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDialogo.Location = new System.Drawing.Point(54, 189);
            this.pictureBoxDialogo.Name = "pictureBoxDialogo";
            this.pictureBoxDialogo.Size = new System.Drawing.Size(116, 84);
            this.pictureBoxDialogo.TabIndex = 7;
            this.pictureBoxDialogo.TabStop = false;
            // 
            // labelDialogo
            // 
            this.labelDialogo.AutoSize = true;
            this.labelDialogo.BackColor = System.Drawing.Color.White;
            this.labelDialogo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDialogo.ForeColor = System.Drawing.Color.Black;
            this.labelDialogo.Location = new System.Drawing.Point(68, 210);
            this.labelDialogo.Name = "labelDialogo";
            this.labelDialogo.Size = new System.Drawing.Size(84, 28);
            this.labelDialogo.TabIndex = 6;
            this.labelDialogo.Text = "Click Me!";
            // 
            // Tablero_Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fondo_informacion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.labelDialogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxDialogo);
            this.Controls.Add(this.pictureBoxViborita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Tablero_Informacion";
            this.Text = "Acerca de La Viborita";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fondoLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fondoLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fondoLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViborita)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDialogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxViborita;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBoxDialogo;
        public System.Windows.Forms.Label labelDialogo;
    }
}