namespace WinLabTorneo
{
    partial class WinInformacion
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
            dataInfo = new DataGridView();
            NombreJugador = new DataGridViewTextBoxColumn();
            Equipo = new DataGridViewTextBoxColumn();
            Camisola = new DataGridViewTextBoxColumn();
            Amarillas = new DataGridViewTextBoxColumn();
            Rojas = new DataGridViewTextBoxColumn();
            Goles = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Columns.AddRange(new DataGridViewColumn[] { NombreJugador, Equipo, Camisola, Amarillas, Rojas, Goles });
            dataInfo.Location = new Point(12, 12);
            dataInfo.Name = "dataInfo";
            dataInfo.Size = new Size(645, 429);
            dataInfo.TabIndex = 0;
            // 
            // NombreJugador
            // 
            NombreJugador.HeaderText = "Nombre Jugador";
            NombreJugador.Name = "NombreJugador";
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            // 
            // Camisola
            // 
            Camisola.HeaderText = "Camisola";
            Camisola.Name = "Camisola";
            // 
            // Amarillas
            // 
            Amarillas.HeaderText = "Amarillas";
            Amarillas.Name = "Amarillas";
            // 
            // Rojas
            // 
            Rojas.HeaderText = "Rojas";
            Rojas.Name = "Rojas";
            // 
            // Goles
            // 
            Goles.HeaderText = "Goles";
            Goles.Name = "Goles";
            // 
            // WinInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 452);
            Controls.Add(dataInfo);
            Name = "WinInformacion";
            Text = "WinInformacion";
            Load += WinInformacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataInfo;
        private DataGridViewTextBoxColumn NombreJugador;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Camisola;
        private DataGridViewTextBoxColumn Amarillas;
        private DataGridViewTextBoxColumn Rojas;
        private DataGridViewTextBoxColumn Goles;
    }
}