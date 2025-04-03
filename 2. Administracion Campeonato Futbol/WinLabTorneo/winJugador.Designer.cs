namespace WinLabTorneo
{
    partial class winJugador
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
            lblNombreJugador = new Label();
            lblNoCamisola = new Label();
            lblNombreEquipo = new Label();
            CBNombreEquipo = new ComboBox();
            txtNombreJugador = new TextBox();
            txtNoCamisola = new TextBox();
            btnAgregarJugador = new Button();
            SuspendLayout();
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            lblNombreJugador.Location = new Point(12, 9);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(231, 30);
            lblNombreJugador.TabIndex = 0;
            lblNombreJugador.Text = "Nombre Jugador";
            // 
            // lblNoCamisola
            // 
            lblNoCamisola.AutoSize = true;
            lblNoCamisola.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            lblNoCamisola.Location = new Point(15, 55);
            lblNoCamisola.Name = "lblNoCamisola";
            lblNoCamisola.Size = new Size(178, 30);
            lblNoCamisola.TabIndex = 1;
            lblNoCamisola.Text = "No. Camisola";
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            lblNombreEquipo.Location = new Point(15, 101);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(214, 30);
            lblNombreEquipo.TabIndex = 2;
            lblNombreEquipo.Text = "Nombre Equipo";
            // 
            // CBNombreEquipo
            // 
            CBNombreEquipo.FormattingEnabled = true;
            CBNombreEquipo.Location = new Point(249, 101);
            CBNombreEquipo.Name = "CBNombreEquipo";
            CBNombreEquipo.Size = new Size(181, 23);
            CBNombreEquipo.TabIndex = 3;
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(249, 9);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(181, 23);
            txtNombreJugador.TabIndex = 4;
            // 
            // txtNoCamisola
            // 
            txtNoCamisola.Location = new Point(249, 55);
            txtNoCamisola.Name = "txtNoCamisola";
            txtNoCamisola.Size = new Size(181, 23);
            txtNoCamisola.TabIndex = 5;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.BackColor = SystemColors.MenuHighlight;
            btnAgregarJugador.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            btnAgregarJugador.ForeColor = SystemColors.ControlLightLight;
            btnAgregarJugador.Location = new Point(127, 144);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(175, 73);
            btnAgregarJugador.TabIndex = 6;
            btnAgregarJugador.Text = "Agregar Jugador";
            btnAgregarJugador.UseVisualStyleBackColor = false;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // winJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 226);
            Controls.Add(btnAgregarJugador);
            Controls.Add(txtNoCamisola);
            Controls.Add(txtNombreJugador);
            Controls.Add(CBNombreEquipo);
            Controls.Add(lblNombreEquipo);
            Controls.Add(lblNoCamisola);
            Controls.Add(lblNombreJugador);
            Name = "winJugador";
            Text = "Menu Jugador";
            Load += winJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreJugador;
        private Label lblNoCamisola;
        private Label lblNombreEquipo;
        private ComboBox CBNombreEquipo;
        private TextBox txtNombreJugador;
        private TextBox txtNoCamisola;
        private Button btnAgregarJugador;
    }
}