namespace WinLabTorneo
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreacionTorneo = new Button();
            btnCreacionEquipo = new Button();
            btnCreacionJugador = new Button();
            btnInformacion = new Button();
            SuspendLayout();
            // 
            // btnCreacionTorneo
            // 
            btnCreacionTorneo.BackColor = SystemColors.MenuHighlight;
            btnCreacionTorneo.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            btnCreacionTorneo.ForeColor = SystemColors.Control;
            btnCreacionTorneo.Location = new Point(12, 12);
            btnCreacionTorneo.Name = "btnCreacionTorneo";
            btnCreacionTorneo.Size = new Size(235, 82);
            btnCreacionTorneo.TabIndex = 0;
            btnCreacionTorneo.Text = "Creación de Torneo";
            btnCreacionTorneo.UseVisualStyleBackColor = false;
            btnCreacionTorneo.Click += btnCreacionTorneo_Click;
            // 
            // btnCreacionEquipo
            // 
            btnCreacionEquipo.BackColor = SystemColors.MenuHighlight;
            btnCreacionEquipo.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            btnCreacionEquipo.ForeColor = SystemColors.Control;
            btnCreacionEquipo.Location = new Point(12, 100);
            btnCreacionEquipo.Name = "btnCreacionEquipo";
            btnCreacionEquipo.Size = new Size(235, 82);
            btnCreacionEquipo.TabIndex = 1;
            btnCreacionEquipo.Text = "Creación de Equipo";
            btnCreacionEquipo.UseVisualStyleBackColor = false;
            btnCreacionEquipo.Click += btnCreacionEquipo_Click;
            // 
            // btnCreacionJugador
            // 
            btnCreacionJugador.BackColor = SystemColors.MenuHighlight;
            btnCreacionJugador.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            btnCreacionJugador.ForeColor = SystemColors.Control;
            btnCreacionJugador.Location = new Point(12, 188);
            btnCreacionJugador.Name = "btnCreacionJugador";
            btnCreacionJugador.Size = new Size(235, 82);
            btnCreacionJugador.TabIndex = 2;
            btnCreacionJugador.Text = "Creación de Jugador";
            btnCreacionJugador.UseVisualStyleBackColor = false;
            btnCreacionJugador.Click += btnCreacionJugador_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.BackColor = SystemColors.MenuHighlight;
            btnInformacion.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            btnInformacion.ForeColor = SystemColors.Control;
            btnInformacion.Location = new Point(12, 276);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(235, 82);
            btnInformacion.TabIndex = 3;
            btnInformacion.Text = "Ver Información";
            btnInformacion.UseVisualStyleBackColor = false;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 381);
            Controls.Add(btnInformacion);
            Controls.Add(btnCreacionJugador);
            Controls.Add(btnCreacionEquipo);
            Controls.Add(btnCreacionTorneo);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreacionTorneo;
        private Button btnCreacionEquipo;
        private Button btnCreacionJugador;
        private Button btnInformacion;
    }
}
