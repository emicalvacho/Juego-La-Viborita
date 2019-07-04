namespace LogicaDelJuego
{
    partial class Tablero_Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero_Ayuda));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxInstrucciones = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControlObjetivo = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlObjetivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(652, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resultados";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(26, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox2.Size = new System.Drawing.Size(600, 285);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "  Si la diferencia entre las fichas iniciales con la actual es igual a:\n - CERO: " +
    "saliste HECHO.\n - MAYOR A CERO: saliste con GANANCIA.\n - MENOR A CERO: saliste c" +
    "on PERDIDA.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.richTextBoxInstrucciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "¿Cómo se juega?";
            // 
            // richTextBoxInstrucciones
            // 
            this.richTextBoxInstrucciones.Location = new System.Drawing.Point(26, 20);
            this.richTextBoxInstrucciones.Name = "richTextBoxInstrucciones";
            this.richTextBoxInstrucciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxInstrucciones.Size = new System.Drawing.Size(600, 285);
            this.richTextBoxInstrucciones.TabIndex = 2;
            this.richTextBoxInstrucciones.Text = resources.GetString("richTextBoxInstrucciones.Text");
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Crimson;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Objetivo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(26, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(600, 285);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Este es un juego de dados que consiste en apostar por un número y si el mismo sal" +
    "e cuando se tiran los dados podrás llevarte lo acumulado en el pozo.";
            // 
            // tabControlObjetivo
            // 
            this.tabControlObjetivo.Controls.Add(this.tabPage1);
            this.tabControlObjetivo.Controls.Add(this.tabPage2);
            this.tabControlObjetivo.Controls.Add(this.tabPage3);
            this.tabControlObjetivo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlObjetivo.Location = new System.Drawing.Point(36, 60);
            this.tabControlObjetivo.Name = "tabControlObjetivo";
            this.tabControlObjetivo.SelectedIndex = 0;
            this.tabControlObjetivo.Size = new System.Drawing.Size(660, 370);
            this.tabControlObjetivo.TabIndex = 0;
            // 
            // Tablero_Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fondo_ayuda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.tabControlObjetivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Tablero_Ayuda";
            this.Text = "Ayuda";
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControlObjetivo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxInstrucciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControlObjetivo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}