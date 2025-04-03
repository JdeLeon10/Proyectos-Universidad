namespace LaboratorioColasEstructurasDeDatos
{
    partial class frmColas
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
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            cmbOpciones = new ComboBox();
            lbDeposito = new ListBox();
            lbRetiro = new ListBox();
            lbAtencionAlCliente = new ListBox();
            btnDeposito = new Button();
            btnRetiro = new Button();
            btnAtencionAlCliente = new Button();
            lblNombre = new Label();
            lblCola = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.MenuHighlight;
            btnRegistrar.Font = new Font("Impact", 14.25F);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(12, 113);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(147, 44);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbOpciones
            // 
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Items.AddRange(new object[] { "Deposito", "Retiro", "Atención al Cliente" });
            cmbOpciones.Location = new Point(12, 84);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(147, 23);
            cmbOpciones.TabIndex = 2;
            // 
            // lbDeposito
            // 
            lbDeposito.FormattingEnabled = true;
            lbDeposito.ItemHeight = 15;
            lbDeposito.Location = new Point(177, 20);
            lbDeposito.Name = "lbDeposito";
            lbDeposito.Size = new Size(125, 109);
            lbDeposito.TabIndex = 3;
            // 
            // lbRetiro
            // 
            lbRetiro.FormattingEnabled = true;
            lbRetiro.ItemHeight = 15;
            lbRetiro.Location = new Point(308, 20);
            lbRetiro.Name = "lbRetiro";
            lbRetiro.Size = new Size(125, 109);
            lbRetiro.TabIndex = 4;
            // 
            // lbAtencionAlCliente
            // 
            lbAtencionAlCliente.FormattingEnabled = true;
            lbAtencionAlCliente.ItemHeight = 15;
            lbAtencionAlCliente.Location = new Point(439, 20);
            lbAtencionAlCliente.Name = "lbAtencionAlCliente";
            lbAtencionAlCliente.Size = new Size(125, 109);
            lbAtencionAlCliente.TabIndex = 5;
            // 
            // btnDeposito
            // 
            btnDeposito.BackColor = SystemColors.MenuHighlight;
            btnDeposito.Font = new Font("Impact", 14.25F);
            btnDeposito.ForeColor = SystemColors.ButtonHighlight;
            btnDeposito.Location = new Point(177, 135);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(125, 84);
            btnDeposito.TabIndex = 6;
            btnDeposito.Text = "Realizar deposito";
            btnDeposito.UseVisualStyleBackColor = false;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnRetiro
            // 
            btnRetiro.BackColor = SystemColors.MenuHighlight;
            btnRetiro.Font = new Font("Impact", 14.25F);
            btnRetiro.ForeColor = SystemColors.ButtonHighlight;
            btnRetiro.Location = new Point(308, 135);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(125, 84);
            btnRetiro.TabIndex = 7;
            btnRetiro.Text = "Realizar retiro";
            btnRetiro.UseVisualStyleBackColor = false;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // btnAtencionAlCliente
            // 
            btnAtencionAlCliente.BackColor = SystemColors.MenuHighlight;
            btnAtencionAlCliente.Font = new Font("Impact", 14.25F);
            btnAtencionAlCliente.ForeColor = SystemColors.ButtonHighlight;
            btnAtencionAlCliente.Location = new Point(439, 135);
            btnAtencionAlCliente.Name = "btnAtencionAlCliente";
            btnAtencionAlCliente.Size = new Size(125, 84);
            btnAtencionAlCliente.TabIndex = 8;
            btnAtencionAlCliente.Text = "Pasar a atención al cliente";
            btnAtencionAlCliente.UseVisualStyleBackColor = false;
            btnAtencionAlCliente.Click += btnAtencionAlCliente_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(33, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(105, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Ingrese su nombre";
            // 
            // lblCola
            // 
            lblCola.AutoSize = true;
            lblCola.Location = new Point(26, 66);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(118, 15);
            lblCola.TabIndex = 10;
            lblCola.Text = "Transacción a realizar";
            // 
            // frmColas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 238);
            Controls.Add(lblCola);
            Controls.Add(lblNombre);
            Controls.Add(btnAtencionAlCliente);
            Controls.Add(btnRetiro);
            Controls.Add(btnDeposito);
            Controls.Add(lbAtencionAlCliente);
            Controls.Add(lbRetiro);
            Controls.Add(lbDeposito);
            Controls.Add(cmbOpciones);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombre);
            Name = "frmColas";
            Text = "Menu Cola";
            Load += frmColas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnRegistrar;
        private ComboBox cmbOpciones;
        private ListBox lbDeposito;
        private ListBox lbRetiro;
        private ListBox lbAtencionAlCliente;
        private Button btnDeposito;
        private Button btnRetiro;
        private Button btnAtencionAlCliente;
        private Label lblNombre;
        private Label lblCola;
    }
}
