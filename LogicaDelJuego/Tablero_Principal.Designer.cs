namespace LogicaDelJuego
{
    partial class Tablero_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero_Principal));
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum12 = new System.Windows.Forms.Button();
            this.buttonNum11 = new System.Windows.Forms.Button();
            this.buttonNum10 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonCubilete = new System.Windows.Forms.Button();
            this.pictureBoxLeftHand = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightHand = new System.Windows.Forms.PictureBox();
            this.pictureBoxFichasPozo = new System.Windows.Forms.PictureBox();
            this.menuStripJuego = new System.Windows.Forms.MenuStrip();
            this.partidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abandonarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rakingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.labelFichas = new System.Windows.Forms.Label();
            this.textBoxNombreUser = new System.Windows.Forms.TextBox();
            this.textBoxMisFichas = new System.Windows.Forms.TextBox();
            this.pictureBoxRightHandUP = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftHandUp = new System.Windows.Forms.PictureBox();
            this.textBoxNombreAdv = new System.Windows.Forms.TextBox();
            this.labelAdversario = new System.Windows.Forms.Label();
            this.textBoxFichasAdv = new System.Windows.Forms.TextBox();
            this.labelAdvFichas = new System.Windows.Forms.Label();
            this.labelPozo = new System.Windows.Forms.Label();
            this.textBoxPozo = new System.Windows.Forms.TextBox();
            this.pictureBoxDado1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado2 = new System.Windows.Forms.PictureBox();
            this.labelNumElegido = new System.Windows.Forms.Label();
            this.textBoxNumElegido = new System.Windows.Forms.TextBox();
            this.pictureBoxMisFichas = new System.Windows.Forms.PictureBox();
            this.pictureBoxFichaAdv = new System.Windows.Forms.PictureBox();
            this.labelMensaje1 = new System.Windows.Forms.Label();
            this.labelMensaje2 = new System.Windows.Forms.Label();
            this.timerDados = new System.Windows.Forms.Timer(this.components);
            this.timerPausa = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFichasPozo)).BeginInit();
            this.menuStripJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightHandUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftHandUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMisFichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFichaAdv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNum2
            // 
            this.buttonNum2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum2.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum2.BackgroundImage = global::LogicaDelJuego.Properties.Resources.button_numero_desactivado;
            this.buttonNum2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum2.FlatAppearance.BorderSize = 0;
            this.buttonNum2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum2.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum2.Location = new System.Drawing.Point(376, 415);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(64, 64);
            this.buttonNum2.TabIndex = 1;
            this.buttonNum2.Tag = "num";
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = false;
            this.buttonNum2.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum2.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum2.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum3
            // 
            this.buttonNum3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum3.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum3.BackgroundImage")));
            this.buttonNum3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum3.FlatAppearance.BorderSize = 0;
            this.buttonNum3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum3.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum3.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum3.Location = new System.Drawing.Point(446, 415);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(64, 64);
            this.buttonNum3.TabIndex = 2;
            this.buttonNum3.Tag = "num";
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = false;
            this.buttonNum3.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum3.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum3.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum4
            // 
            this.buttonNum4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum4.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum4.BackgroundImage")));
            this.buttonNum4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum4.FlatAppearance.BorderSize = 0;
            this.buttonNum4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum4.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum4.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum4.Location = new System.Drawing.Point(516, 415);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(64, 64);
            this.buttonNum4.TabIndex = 3;
            this.buttonNum4.Tag = "num";
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = false;
            this.buttonNum4.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum4.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum4.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum5
            // 
            this.buttonNum5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum5.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum5.BackgroundImage")));
            this.buttonNum5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum5.FlatAppearance.BorderSize = 0;
            this.buttonNum5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum5.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum5.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum5.Location = new System.Drawing.Point(586, 415);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(64, 64);
            this.buttonNum5.TabIndex = 4;
            this.buttonNum5.Tag = "num";
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = false;
            this.buttonNum5.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum5.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum5.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum6
            // 
            this.buttonNum6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum6.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum6.BackgroundImage")));
            this.buttonNum6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum6.FlatAppearance.BorderSize = 0;
            this.buttonNum6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum6.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum6.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum6.Location = new System.Drawing.Point(656, 415);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(64, 64);
            this.buttonNum6.TabIndex = 5;
            this.buttonNum6.Tag = "num";
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = false;
            this.buttonNum6.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum6.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum6.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum12
            // 
            this.buttonNum12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum12.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum12.BackgroundImage")));
            this.buttonNum12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum12.FlatAppearance.BorderSize = 0;
            this.buttonNum12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum12.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum12.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum12.Location = new System.Drawing.Point(656, 485);
            this.buttonNum12.Name = "buttonNum12";
            this.buttonNum12.Size = new System.Drawing.Size(64, 64);
            this.buttonNum12.TabIndex = 11;
            this.buttonNum12.Tag = "num";
            this.buttonNum12.Text = "12";
            this.buttonNum12.UseVisualStyleBackColor = false;
            this.buttonNum12.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum12.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum12.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum11
            // 
            this.buttonNum11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum11.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum11.BackgroundImage")));
            this.buttonNum11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum11.FlatAppearance.BorderSize = 0;
            this.buttonNum11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum11.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum11.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum11.Location = new System.Drawing.Point(586, 485);
            this.buttonNum11.Name = "buttonNum11";
            this.buttonNum11.Size = new System.Drawing.Size(64, 64);
            this.buttonNum11.TabIndex = 10;
            this.buttonNum11.Tag = "num";
            this.buttonNum11.Text = "11";
            this.buttonNum11.UseVisualStyleBackColor = false;
            this.buttonNum11.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum11.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum11.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum10
            // 
            this.buttonNum10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum10.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum10.BackgroundImage")));
            this.buttonNum10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum10.FlatAppearance.BorderSize = 0;
            this.buttonNum10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum10.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum10.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum10.Location = new System.Drawing.Point(516, 485);
            this.buttonNum10.Name = "buttonNum10";
            this.buttonNum10.Size = new System.Drawing.Size(64, 64);
            this.buttonNum10.TabIndex = 9;
            this.buttonNum10.Tag = "num";
            this.buttonNum10.Text = "10";
            this.buttonNum10.UseVisualStyleBackColor = false;
            this.buttonNum10.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum10.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum10.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum9
            // 
            this.buttonNum9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum9.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum9.BackgroundImage")));
            this.buttonNum9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum9.FlatAppearance.BorderSize = 0;
            this.buttonNum9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum9.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum9.Location = new System.Drawing.Point(446, 485);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(64, 64);
            this.buttonNum9.TabIndex = 8;
            this.buttonNum9.Tag = "num";
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = false;
            this.buttonNum9.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum9.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum9.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNum8.BackColor = System.Drawing.Color.Transparent;
            this.buttonNum8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNum8.BackgroundImage")));
            this.buttonNum8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNum8.FlatAppearance.BorderSize = 0;
            this.buttonNum8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNum8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum8.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum8.ForeColor = System.Drawing.Color.Tomato;
            this.buttonNum8.Location = new System.Drawing.Point(376, 485);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(64, 64);
            this.buttonNum8.TabIndex = 7;
            this.buttonNum8.Tag = "num";
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = false;
            this.buttonNum8.Click += new System.EventHandler(this.ClickNumeroElegido);
            this.buttonNum8.MouseLeave += new System.EventHandler(this.buttonNumberLeave);
            this.buttonNum8.MouseHover += new System.EventHandler(this.buttonNumberHover);
            // 
            // buttonCubilete
            // 
            this.buttonCubilete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCubilete.BackColor = System.Drawing.Color.Transparent;
            this.buttonCubilete.BackgroundImage = global::LogicaDelJuego.Properties.Resources.cubilete;
            this.buttonCubilete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCubilete.FlatAppearance.BorderSize = 0;
            this.buttonCubilete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCubilete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCubilete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCubilete.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCubilete.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonCubilete.Location = new System.Drawing.Point(720, 177);
            this.buttonCubilete.Name = "buttonCubilete";
            this.buttonCubilete.Size = new System.Drawing.Size(130, 178);
            this.buttonCubilete.TabIndex = 12;
            this.buttonCubilete.Tag = "cubilete";
            this.buttonCubilete.UseVisualStyleBackColor = false;
            this.buttonCubilete.Click += new System.EventHandler(this.ClickCubilete);
            // 
            // pictureBoxLeftHand
            // 
            this.pictureBoxLeftHand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxLeftHand.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeftHand.BackgroundImage = global::LogicaDelJuego.Properties.Resources.mano_izquierda_abajo;
            this.pictureBoxLeftHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLeftHand.Location = new System.Drawing.Point(252, 388);
            this.pictureBoxLeftHand.Name = "pictureBoxLeftHand";
            this.pictureBoxLeftHand.Size = new System.Drawing.Size(118, 173);
            this.pictureBoxLeftHand.TabIndex = 13;
            this.pictureBoxLeftHand.TabStop = false;
            // 
            // pictureBoxRightHand
            // 
            this.pictureBoxRightHand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxRightHand.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRightHand.BackgroundImage = global::LogicaDelJuego.Properties.Resources.mano_derecha_abajo;
            this.pictureBoxRightHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRightHand.Location = new System.Drawing.Point(732, 388);
            this.pictureBoxRightHand.Name = "pictureBoxRightHand";
            this.pictureBoxRightHand.Size = new System.Drawing.Size(118, 173);
            this.pictureBoxRightHand.TabIndex = 14;
            this.pictureBoxRightHand.TabStop = false;
            // 
            // pictureBoxFichasPozo
            // 
            this.pictureBoxFichasPozo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxFichasPozo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFichasPozo.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fichas_pozo;
            this.pictureBoxFichasPozo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFichasPozo.Location = new System.Drawing.Point(85, 238);
            this.pictureBoxFichasPozo.Name = "pictureBoxFichasPozo";
            this.pictureBoxFichasPozo.Size = new System.Drawing.Size(112, 129);
            this.pictureBoxFichasPozo.TabIndex = 17;
            this.pictureBoxFichasPozo.TabStop = false;
            // 
            // menuStripJuego
            // 
            this.menuStripJuego.BackColor = System.Drawing.Color.Transparent;
            this.menuStripJuego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStripJuego.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStripJuego.Location = new System.Drawing.Point(0, 0);
            this.menuStripJuego.Name = "menuStripJuego";
            this.menuStripJuego.Size = new System.Drawing.Size(884, 33);
            this.menuStripJuego.TabIndex = 18;
            this.menuStripJuego.Text = "menuStrip1";
            // 
            // partidaToolStripMenuItem
            // 
            this.partidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.finalizarJuegoToolStripMenuItem,
            this.abandonarJuegoToolStripMenuItem});
            this.partidaToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partidaToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            this.partidaToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.partidaToolStripMenuItem.Text = "Partida";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            this.nuevoJuegoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.nuevoJuegoToolStripMenuItem.Text = "Comenzar Juego";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.nuevoJuegoToolStripMenuItem_Click);
            // 
            // finalizarJuegoToolStripMenuItem
            // 
            this.finalizarJuegoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.finalizarJuegoToolStripMenuItem.Name = "finalizarJuegoToolStripMenuItem";
            this.finalizarJuegoToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.finalizarJuegoToolStripMenuItem.Text = "Plantarse";
            this.finalizarJuegoToolStripMenuItem.Click += new System.EventHandler(this.finalizarJuegoToolStripMenuItem_Click);
            // 
            // abandonarJuegoToolStripMenuItem
            // 
            this.abandonarJuegoToolStripMenuItem.Name = "abandonarJuegoToolStripMenuItem";
            this.abandonarJuegoToolStripMenuItem.Size = new System.Drawing.Size(251, 30);
            this.abandonarJuegoToolStripMenuItem.Text = "Abandonar Juego";
            this.abandonarJuegoToolStripMenuItem.Click += new System.EventHandler(this.abandonarJuegoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rakingToolStripMenuItem,
            this.instruccionesToolStripMenuItem,
            this.acercaDelJuegoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.ayudaToolStripMenuItem.Text = "Información";
            // 
            // rakingToolStripMenuItem
            // 
            this.rakingToolStripMenuItem.Name = "rakingToolStripMenuItem";
            this.rakingToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.rakingToolStripMenuItem.Text = "Raking";
            this.rakingToolStripMenuItem.Click += new System.EventHandler(this.rakingToolStripMenuItem_Click);
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.instruccionesToolStripMenuItem.Text = "Instrucciones";
            this.instruccionesToolStripMenuItem.Click += new System.EventHandler(this.instruccionesToolStripMenuItem_Click);
            // 
            // acercaDelJuegoToolStripMenuItem
            // 
            this.acercaDelJuegoToolStripMenuItem.Name = "acercaDelJuegoToolStripMenuItem";
            this.acercaDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.acercaDelJuegoToolStripMenuItem.Text = "Acerca del juego";
            this.acercaDelJuegoToolStripMenuItem.Click += new System.EventHandler(this.acercaDelJuegoToolStripMenuItem_Click);
            // 
            // labelNombreUser
            // 
            this.labelNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNombreUser.AutoSize = true;
            this.labelNombreUser.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreUser.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNombreUser.Location = new System.Drawing.Point(79, 404);
            this.labelNombreUser.Name = "labelNombreUser";
            this.labelNombreUser.Size = new System.Drawing.Size(119, 31);
            this.labelNombreUser.TabIndex = 19;
            this.labelNombreUser.Text = "Jugador:";
            // 
            // labelFichas
            // 
            this.labelFichas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFichas.AutoSize = true;
            this.labelFichas.BackColor = System.Drawing.Color.Transparent;
            this.labelFichas.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelFichas.Location = new System.Drawing.Point(56, 476);
            this.labelFichas.Name = "labelFichas";
            this.labelFichas.Size = new System.Drawing.Size(145, 31);
            this.labelFichas.TabIndex = 20;
            this.labelFichas.Text = "Mis fichas:";
            // 
            // textBoxNombreUser
            // 
            this.textBoxNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNombreUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxNombreUser.Enabled = false;
            this.textBoxNombreUser.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUser.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxNombreUser.Location = new System.Drawing.Point(33, 437);
            this.textBoxNombreUser.Name = "textBoxNombreUser";
            this.textBoxNombreUser.ReadOnly = true;
            this.textBoxNombreUser.Size = new System.Drawing.Size(213, 34);
            this.textBoxNombreUser.TabIndex = 21;
            this.textBoxNombreUser.TabStop = false;
            this.textBoxNombreUser.Tag = "nomJugador";
            this.textBoxNombreUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMisFichas
            // 
            this.textBoxMisFichas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMisFichas.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMisFichas.Enabled = false;
            this.textBoxMisFichas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMisFichas.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxMisFichas.Location = new System.Drawing.Point(128, 511);
            this.textBoxMisFichas.Name = "textBoxMisFichas";
            this.textBoxMisFichas.ReadOnly = true;
            this.textBoxMisFichas.Size = new System.Drawing.Size(50, 34);
            this.textBoxMisFichas.TabIndex = 22;
            this.textBoxMisFichas.TabStop = false;
            this.textBoxMisFichas.Tag = "fichasJugador";
            this.textBoxMisFichas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxRightHandUP
            // 
            this.pictureBoxRightHandUP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxRightHandUP.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRightHandUP.BackgroundImage = global::LogicaDelJuego.Properties.Resources.mano_derecha_arriba;
            this.pictureBoxRightHandUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRightHandUP.Location = new System.Drawing.Point(252, 0);
            this.pictureBoxRightHandUP.Name = "pictureBoxRightHandUP";
            this.pictureBoxRightHandUP.Size = new System.Drawing.Size(118, 144);
            this.pictureBoxRightHandUP.TabIndex = 23;
            this.pictureBoxRightHandUP.TabStop = false;
            // 
            // pictureBoxLeftHandUp
            // 
            this.pictureBoxLeftHandUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLeftHandUp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeftHandUp.BackgroundImage = global::LogicaDelJuego.Properties.Resources.mano_izquierda_arriba;
            this.pictureBoxLeftHandUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLeftHandUp.Location = new System.Drawing.Point(732, 0);
            this.pictureBoxLeftHandUp.Name = "pictureBoxLeftHandUp";
            this.pictureBoxLeftHandUp.Size = new System.Drawing.Size(118, 144);
            this.pictureBoxLeftHandUp.TabIndex = 24;
            this.pictureBoxLeftHandUp.TabStop = false;
            // 
            // textBoxNombreAdv
            // 
            this.textBoxNombreAdv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombreAdv.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxNombreAdv.Enabled = false;
            this.textBoxNombreAdv.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreAdv.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxNombreAdv.Location = new System.Drawing.Point(456, 39);
            this.textBoxNombreAdv.Name = "textBoxNombreAdv";
            this.textBoxNombreAdv.ReadOnly = true;
            this.textBoxNombreAdv.Size = new System.Drawing.Size(224, 34);
            this.textBoxNombreAdv.TabIndex = 26;
            this.textBoxNombreAdv.TabStop = false;
            this.textBoxNombreAdv.Tag = "advNombre";
            this.textBoxNombreAdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAdversario
            // 
            this.labelAdversario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAdversario.AutoSize = true;
            this.labelAdversario.BackColor = System.Drawing.Color.Transparent;
            this.labelAdversario.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdversario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdversario.Location = new System.Drawing.Point(488, 8);
            this.labelAdversario.Name = "labelAdversario";
            this.labelAdversario.Size = new System.Drawing.Size(149, 31);
            this.labelAdversario.TabIndex = 25;
            this.labelAdversario.Text = "Adversario:";
            // 
            // textBoxFichasAdv
            // 
            this.textBoxFichasAdv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFichasAdv.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFichasAdv.Enabled = false;
            this.textBoxFichasAdv.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFichasAdv.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxFichasAdv.Location = new System.Drawing.Point(564, 112);
            this.textBoxFichasAdv.Name = "textBoxFichasAdv";
            this.textBoxFichasAdv.ReadOnly = true;
            this.textBoxFichasAdv.Size = new System.Drawing.Size(50, 34);
            this.textBoxFichasAdv.TabIndex = 28;
            this.textBoxFichasAdv.TabStop = false;
            this.textBoxFichasAdv.Tag = "advFichas";
            this.textBoxFichasAdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAdvFichas
            // 
            this.labelAdvFichas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAdvFichas.AutoSize = true;
            this.labelAdvFichas.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvFichas.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvFichas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdvFichas.Location = new System.Drawing.Point(492, 78);
            this.labelAdvFichas.Name = "labelAdvFichas";
            this.labelAdvFichas.Size = new System.Drawing.Size(145, 31);
            this.labelAdvFichas.TabIndex = 27;
            this.labelAdvFichas.Text = "Sus fichas:";
            // 
            // labelPozo
            // 
            this.labelPozo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPozo.AutoSize = true;
            this.labelPozo.BackColor = System.Drawing.Color.Transparent;
            this.labelPozo.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPozo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPozo.Location = new System.Drawing.Point(96, 190);
            this.labelPozo.Name = "labelPozo";
            this.labelPozo.Size = new System.Drawing.Size(82, 31);
            this.labelPozo.TabIndex = 29;
            this.labelPozo.Text = "Pozo:";
            // 
            // textBoxPozo
            // 
            this.textBoxPozo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPozo.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPozo.Enabled = false;
            this.textBoxPozo.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPozo.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxPozo.Location = new System.Drawing.Point(184, 190);
            this.textBoxPozo.Name = "textBoxPozo";
            this.textBoxPozo.ReadOnly = true;
            this.textBoxPozo.Size = new System.Drawing.Size(41, 34);
            this.textBoxPozo.TabIndex = 30;
            this.textBoxPozo.TabStop = false;
            this.textBoxPozo.Tag = "pozo";
            this.textBoxPozo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxDado1
            // 
            this.pictureBoxDado1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDado1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDado1.Location = new System.Drawing.Point(501, 248);
            this.pictureBoxDado1.Name = "pictureBoxDado1";
            this.pictureBoxDado1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxDado1.TabIndex = 31;
            this.pictureBoxDado1.TabStop = false;
            // 
            // pictureBoxDado2
            // 
            this.pictureBoxDado2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDado2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDado2.Location = new System.Drawing.Point(571, 298);
            this.pictureBoxDado2.Name = "pictureBoxDado2";
            this.pictureBoxDado2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxDado2.TabIndex = 32;
            this.pictureBoxDado2.TabStop = false;
            // 
            // labelNumElegido
            // 
            this.labelNumElegido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumElegido.AutoSize = true;
            this.labelNumElegido.BackColor = System.Drawing.Color.Transparent;
            this.labelNumElegido.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumElegido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumElegido.Location = new System.Drawing.Point(30, 145);
            this.labelNumElegido.Name = "labelNumElegido";
            this.labelNumElegido.Size = new System.Drawing.Size(148, 31);
            this.labelNumElegido.TabIndex = 33;
            this.labelNumElegido.Text = "Nº elegido:";
            // 
            // textBoxNumElegido
            // 
            this.textBoxNumElegido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNumElegido.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxNumElegido.Enabled = false;
            this.textBoxNumElegido.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumElegido.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxNumElegido.Location = new System.Drawing.Point(184, 140);
            this.textBoxNumElegido.Name = "textBoxNumElegido";
            this.textBoxNumElegido.ReadOnly = true;
            this.textBoxNumElegido.Size = new System.Drawing.Size(41, 34);
            this.textBoxNumElegido.TabIndex = 34;
            this.textBoxNumElegido.TabStop = false;
            this.textBoxNumElegido.Tag = "advNumero";
            this.textBoxNumElegido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxMisFichas
            // 
            this.pictureBoxMisFichas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxMisFichas.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMisFichas.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fichas_usuarios;
            this.pictureBoxMisFichas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMisFichas.Location = new System.Drawing.Point(84, 510);
            this.pictureBoxMisFichas.Name = "pictureBoxMisFichas";
            this.pictureBoxMisFichas.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxMisFichas.TabIndex = 35;
            this.pictureBoxMisFichas.TabStop = false;
            // 
            // pictureBoxFichaAdv
            // 
            this.pictureBoxFichaAdv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxFichaAdv.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFichaAdv.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fichas_usuarios;
            this.pictureBoxFichaAdv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFichaAdv.Location = new System.Drawing.Point(520, 112);
            this.pictureBoxFichaAdv.Name = "pictureBoxFichaAdv";
            this.pictureBoxFichaAdv.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxFichaAdv.TabIndex = 36;
            this.pictureBoxFichaAdv.TabStop = false;
            // 
            // labelMensaje1
            // 
            this.labelMensaje1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMensaje1.AutoSize = true;
            this.labelMensaje1.BackColor = System.Drawing.Color.Transparent;
            this.labelMensaje1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMensaje1.Location = new System.Drawing.Point(288, 158);
            this.labelMensaje1.Name = "labelMensaje1";
            this.labelMensaje1.Size = new System.Drawing.Size(30, 33);
            this.labelMensaje1.TabIndex = 37;
            this.labelMensaje1.Text = "...";
            // 
            // labelMensaje2
            // 
            this.labelMensaje2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMensaje2.AutoSize = true;
            this.labelMensaje2.BackColor = System.Drawing.Color.Transparent;
            this.labelMensaje2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMensaje2.Location = new System.Drawing.Point(288, 191);
            this.labelMensaje2.Name = "labelMensaje2";
            this.labelMensaje2.Size = new System.Drawing.Size(30, 33);
            this.labelMensaje2.TabIndex = 38;
            this.labelMensaje2.Text = "...";
            // 
            // timerDados
            // 
            this.timerDados.Interval = 2000;
            this.timerDados.Tick += new System.EventHandler(this.timerDados_Tick);
            // 
            // timerPausa
            // 
            this.timerPausa.Interval = 700;
            this.timerPausa.Tick += new System.EventHandler(this.timerPausa_Tick);
            // 
            // Tablero_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogicaDelJuego.Properties.Resources.fondo_juego;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.labelMensaje2);
            this.Controls.Add(this.labelMensaje1);
            this.Controls.Add(this.pictureBoxFichaAdv);
            this.Controls.Add(this.pictureBoxMisFichas);
            this.Controls.Add(this.textBoxNumElegido);
            this.Controls.Add(this.labelNumElegido);
            this.Controls.Add(this.pictureBoxDado2);
            this.Controls.Add(this.pictureBoxDado1);
            this.Controls.Add(this.textBoxPozo);
            this.Controls.Add(this.labelPozo);
            this.Controls.Add(this.textBoxFichasAdv);
            this.Controls.Add(this.labelAdvFichas);
            this.Controls.Add(this.textBoxNombreAdv);
            this.Controls.Add(this.labelAdversario);
            this.Controls.Add(this.pictureBoxLeftHandUp);
            this.Controls.Add(this.pictureBoxRightHandUP);
            this.Controls.Add(this.textBoxMisFichas);
            this.Controls.Add(this.textBoxNombreUser);
            this.Controls.Add(this.labelFichas);
            this.Controls.Add(this.labelNombreUser);
            this.Controls.Add(this.pictureBoxFichasPozo);
            this.Controls.Add(this.buttonCubilete);
            this.Controls.Add(this.pictureBoxRightHand);
            this.Controls.Add(this.pictureBoxLeftHand);
            this.Controls.Add(this.buttonNum12);
            this.Controls.Add(this.buttonNum11);
            this.Controls.Add(this.buttonNum10);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.menuStripJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripJuego;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Tablero_Principal";
            this.Text = "La Viborita";
            this.Shown += new System.EventHandler(this.TableroPrincipal_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFichasPozo)).EndInit();
            this.menuStripJuego.ResumeLayout(false);
            this.menuStripJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightHandUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftHandUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMisFichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFichaAdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonNum2;
        public System.Windows.Forms.Button buttonNum3;
        public System.Windows.Forms.Button buttonNum4;
        public System.Windows.Forms.Button buttonNum5;
        public System.Windows.Forms.Button buttonNum6;
        public System.Windows.Forms.Button buttonNum12;
        public System.Windows.Forms.Button buttonNum11;
        public System.Windows.Forms.Button buttonNum10;
        public System.Windows.Forms.Button buttonNum9;
        public System.Windows.Forms.Button buttonNum8;
        public System.Windows.Forms.Button buttonCubilete;
        public System.Windows.Forms.PictureBox pictureBoxLeftHand;
        public System.Windows.Forms.PictureBox pictureBoxRightHand;
        public System.Windows.Forms.PictureBox pictureBoxFichasPozo;
        public System.Windows.Forms.MenuStrip menuStripJuego;
        public System.Windows.Forms.ToolStripMenuItem partidaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem finalizarJuegoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        public System.Windows.Forms.Label labelNombreUser;
        public System.Windows.Forms.Label labelFichas;
        public System.Windows.Forms.TextBox textBoxNombreUser;
        public System.Windows.Forms.TextBox textBoxMisFichas;
        public System.Windows.Forms.PictureBox pictureBoxRightHandUP;
        public System.Windows.Forms.PictureBox pictureBoxLeftHandUp;
        public System.Windows.Forms.TextBox textBoxNombreAdv;
        public System.Windows.Forms.Label labelAdversario;
        public System.Windows.Forms.TextBox textBoxFichasAdv;
        public System.Windows.Forms.Label labelAdvFichas;
        public System.Windows.Forms.Label labelPozo;
        public System.Windows.Forms.TextBox textBoxPozo;
        public System.Windows.Forms.PictureBox pictureBoxDado1;
        public System.Windows.Forms.PictureBox pictureBoxDado2;
        public System.Windows.Forms.Label labelNumElegido;
        public System.Windows.Forms.TextBox textBoxNumElegido;
        public System.Windows.Forms.PictureBox pictureBoxMisFichas;
        public System.Windows.Forms.PictureBox pictureBoxFichaAdv;
        public System.Windows.Forms.Label labelMensaje1;
        public System.Windows.Forms.Label labelMensaje2;
        private System.Windows.Forms.ToolStripMenuItem acercaDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rakingToolStripMenuItem;
        private System.Windows.Forms.Timer timerDados;
        private System.Windows.Forms.Timer timerPausa;
        private System.Windows.Forms.ToolStripMenuItem abandonarJuegoToolStripMenuItem;
    }
}

