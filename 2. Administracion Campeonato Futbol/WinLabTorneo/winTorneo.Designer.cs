namespace WinLabTorneo
{
    partial class winTorneo
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
            btnAgregarTorneo = new Button();
            txtNombreTorneo = new TextBox();
            lblNombreTorneo = new Label();
            SuspendLayout();
            // 
            // btnAgregarTorneo
            // 
            btnAgregarTorneo.BackColor = SystemColors.MenuHighlight;
            btnAgregarTorneo.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            btnAgregarTorneo.ForeColor = SystemColors.ControlLightLight;
            btnAgregarTorneo.Location = new Point(40, 105);
            btnAgregarTorneo.Name = "btnAgregarTorneo";
            btnAgregarTorneo.Size = new Size(175, 73);
            btnAgregarTorneo.TabIndex = 10;
            btnAgregarTorneo.Text = "Agregar Torneo";
            btnAgregarTorneo.UseVisualStyleBackColor = false;
            btnAgregarTorneo.Click += btnAgregarTorneo_Click;
            // 
            // txtNombreTorneo
            // 
            txtNombreTorneo.Location = new Point(40, 65);
            txtNombreTorneo.Name = "txtNombreTorneo";
            txtNombreTorneo.Size = new Size(175, 23);
            txtNombreTorneo.TabIndex = 9;
            // 
            // lblNombreTorneo
            // 
            lblNombreTorneo.AutoSize = true;
            lblNombreTorneo.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            lblNombreTorneo.Location = new Point(24, 20);
            lblNombreTorneo.Name = "lblNombreTorneo";
            lblNombreTorneo.Size = new Size(216, 30);
            lblNombreTorneo.TabIndex = 8;
            lblNombreTorneo.Text = "Nombre Torneo";
            // 
            // winTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 220);
            Controls.Add(btnAgregarTorneo);
            Controls.Add(txtNombreTorneo);
            Controls.Add(lblNombreTorneo);
            Name = "winTorneo";
            Text = "Menu Torneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarTorneo;
        private TextBox txtNombreTorneo;
        private Label lblNombreTorneo;
    }
}