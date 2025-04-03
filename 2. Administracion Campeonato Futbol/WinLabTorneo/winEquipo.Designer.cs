namespace WinLabTorneo
{
    partial class winEquipo
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
            txtNombreEquipo = new TextBox();
            lblNombreEquipo = new Label();
            btnAgregarEquipo = new Button();
            SuspendLayout();
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(46, 66);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(175, 23);
            txtNombreEquipo.TabIndex = 6;
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            lblNombreEquipo.Location = new Point(30, 21);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(214, 30);
            lblNombreEquipo.TabIndex = 5;
            lblNombreEquipo.Text = "Nombre Equipo";
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = SystemColors.MenuHighlight;
            btnAgregarEquipo.Font = new Font("Gill Sans Ultra Bold", 15.75F);
            btnAgregarEquipo.ForeColor = SystemColors.ControlLightLight;
            btnAgregarEquipo.Location = new Point(46, 106);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(175, 73);
            btnAgregarEquipo.TabIndex = 7;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // winEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 207);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(lblNombreEquipo);
            Name = "winEquipo";
            Text = "Menu Equipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreEquipo;
        private Label lblNombreEquipo;
        private Button btnAgregarEquipo;
    }
}