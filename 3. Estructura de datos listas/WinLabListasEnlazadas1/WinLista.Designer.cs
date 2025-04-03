namespace WinLabListasEnlazadas1
{
    partial class WinLista
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
            lblNombreCompleto = new Label();
            lblEdad = new Label();
            btnIngresar = new Button();
            btnViejo = new Button();
            btnJoven = new Button();
            txtNombreCompleto = new TextBox();
            txtEdad = new TextBox();
            lblResultadoNombre = new Label();
            SuspendLayout();
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(25, 36);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(107, 15);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre Completo";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(25, 73);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(137, 126);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnViejo
            // 
            btnViejo.Location = new Point(244, 158);
            btnViejo.Name = "btnViejo";
            btnViejo.Size = new Size(75, 23);
            btnViejo.TabIndex = 3;
            btnViejo.Text = "Viejo";
            btnViejo.UseVisualStyleBackColor = true;
            btnViejo.Click += btnViejo_Click;
            // 
            // btnJoven
            // 
            btnJoven.Location = new Point(25, 158);
            btnJoven.Name = "btnJoven";
            btnJoven.Size = new Size(75, 23);
            btnJoven.TabIndex = 4;
            btnJoven.Text = "Joven";
            btnJoven.UseVisualStyleBackColor = true;
            btnJoven.Click += btnJoven_Click;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(148, 33);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(171, 23);
            txtNombreCompleto.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(148, 70);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(171, 23);
            txtEdad.TabIndex = 6;
            // 
            // lblResultadoNombre
            // 
            lblResultadoNombre.AutoSize = true;
            lblResultadoNombre.Location = new Point(25, 231);
            lblResultadoNombre.Name = "lblResultadoNombre";
            lblResultadoNombre.Size = new Size(106, 15);
            lblResultadoNombre.TabIndex = 7;
            lblResultadoNombre.Text = "Resultado Nombre";
            lblResultadoNombre.Click += lblResultado_Click;
            // 
            // WinLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 306);
            Controls.Add(lblResultadoNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtNombreCompleto);
            Controls.Add(btnJoven);
            Controls.Add(btnViejo);
            Controls.Add(btnIngresar);
            Controls.Add(lblEdad);
            Controls.Add(lblNombreCompleto);
            Name = "WinLista";
            Text = "WinLista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCompleto;
        private Label lblEdad;
        private Button btnIngresar;
        private Button btnViejo;
        private Button btnJoven;
        private TextBox txtNombreCompleto;
        private TextBox txtEdad;
        private Label lblResultadoNombre;
    }
}