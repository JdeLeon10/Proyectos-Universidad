namespace ProyectoFinalAutomatas
{
    partial class Form1
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
            dgvTablaTransiciones = new DataGridView();
            btnBloquearTabla = new Button();
            txtCadenaPrueba = new TextBox();
            btnValidarCadena = new Button();
            lblCadenaPrueba = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLimpiarTabla = new Button();
            Estados = new DataGridViewTextBoxColumn();
            Mas = new DataGridViewTextBoxColumn();
            Menos = new DataGridViewTextBoxColumn();
            Diagonal = new DataGridViewTextBoxColumn();
            Multiplicador = new DataGridViewTextBoxColumn();
            Digito = new DataGridViewTextBoxColumn();
            FDC = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTablaTransiciones).BeginInit();
            SuspendLayout();
            // 
            // dgvTablaTransiciones
            // 
            dgvTablaTransiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaTransiciones.Columns.AddRange(new DataGridViewColumn[] { Estados, Mas, Menos, Diagonal, Multiplicador, Digito, FDC });
            dgvTablaTransiciones.Location = new Point(12, 96);
            dgvTablaTransiciones.Name = "dgvTablaTransiciones";
            dgvTablaTransiciones.Size = new Size(743, 260);
            dgvTablaTransiciones.TabIndex = 0;
            // 
            // btnBloquearTabla
            // 
            btnBloquearTabla.BackColor = Color.LightCoral;
            btnBloquearTabla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBloquearTabla.Location = new Point(801, 96);
            btnBloquearTabla.Name = "btnBloquearTabla";
            btnBloquearTabla.Size = new Size(150, 35);
            btnBloquearTabla.TabIndex = 1;
            btnBloquearTabla.Text = "BLOQUEO TABLA";
            btnBloquearTabla.UseVisualStyleBackColor = false;
            btnBloquearTabla.Click += btnBloquearTabla_Click;
            // 
            // txtCadenaPrueba
            // 
            txtCadenaPrueba.Location = new Point(801, 281);
            txtCadenaPrueba.Name = "txtCadenaPrueba";
            txtCadenaPrueba.Size = new Size(150, 23);
            txtCadenaPrueba.TabIndex = 2;
            // 
            // btnValidarCadena
            // 
            btnValidarCadena.BackColor = Color.SeaGreen;
            btnValidarCadena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnValidarCadena.Location = new Point(801, 321);
            btnValidarCadena.Name = "btnValidarCadena";
            btnValidarCadena.Size = new Size(150, 35);
            btnValidarCadena.TabIndex = 3;
            btnValidarCadena.Text = "VALIDAR CADENA";
            btnValidarCadena.UseVisualStyleBackColor = false;
            btnValidarCadena.Click += btnValidarCadena_Click;
            // 
            // lblCadenaPrueba
            // 
            lblCadenaPrueba.AutoSize = true;
            lblCadenaPrueba.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCadenaPrueba.Location = new Point(799, 259);
            lblCadenaPrueba.Name = "lblCadenaPrueba";
            lblCadenaPrueba.Size = new Size(122, 19);
            lblCadenaPrueba.TabIndex = 4;
            lblCadenaPrueba.Text = "Ingresar Cadena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro", 16F, FontStyle.Bold);
            label1.Location = new Point(315, 27);
            label1.Name = "label1";
            label1.Size = new Size(361, 28);
            label1.TabIndex = 5;
            label1.Text = "PROYECTO TABLA DE TRANSICIONES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 379);
            label2.Name = "label2";
            label2.Size = new Size(215, 15);
            label2.TabIndex = 6;
            label2.Text = "Gabriel Figueros Cardona            22 9287";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 402);
            label3.Name = "label3";
            label3.Size = new Size(215, 15);
            label3.TabIndex = 7;
            label3.Text = "Jeremy Alejandro De Leon Roa   22 2413";
            // 
            // btnLimpiarTabla
            // 
            btnLimpiarTabla.BackColor = Color.Khaki;
            btnLimpiarTabla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiarTabla.Location = new Point(801, 137);
            btnLimpiarTabla.Name = "btnLimpiarTabla";
            btnLimpiarTabla.Size = new Size(150, 35);
            btnLimpiarTabla.TabIndex = 8;
            btnLimpiarTabla.Text = "LIMPIAR TABLA";
            btnLimpiarTabla.UseVisualStyleBackColor = false;
            btnLimpiarTabla.Click += btnLimpiarTabla_Click;
            // 
            // Estados
            // 
            Estados.HeaderText = "Estados";
            Estados.Name = "Estados";
            // 
            // Mas
            // 
            Mas.HeaderText = "+";
            Mas.Name = "Mas";
            // 
            // Menos
            // 
            Menos.HeaderText = "-";
            Menos.Name = "Menos";
            // 
            // Diagonal
            // 
            Diagonal.HeaderText = "/";
            Diagonal.Name = "Diagonal";
            // 
            // Multiplicador
            // 
            Multiplicador.HeaderText = "*";
            Multiplicador.Name = "Multiplicador";
            // 
            // Digito
            // 
            Digito.HeaderText = "Digito";
            Digito.Name = "Digito";
            // 
            // FDC
            // 
            FDC.HeaderText = "FDC";
            FDC.Name = "FDC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(977, 439);
            Controls.Add(btnLimpiarTabla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCadenaPrueba);
            Controls.Add(btnValidarCadena);
            Controls.Add(txtCadenaPrueba);
            Controls.Add(btnBloquearTabla);
            Controls.Add(dgvTablaTransiciones);
            Name = "Form1";
            Text = "TABLA DE TRANSICIONES";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaTransiciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTablaTransiciones;
        private Button btnBloquearTabla;
        private TextBox txtCadenaPrueba;
        private Button btnValidarCadena;
        private Label lblCadenaPrueba;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLimpiarTabla;
        private DataGridViewTextBoxColumn Estados;
        private DataGridViewTextBoxColumn Mas;
        private DataGridViewTextBoxColumn Menos;
        private DataGridViewTextBoxColumn Diagonal;
        private DataGridViewTextBoxColumn Multiplicador;
        private DataGridViewTextBoxColumn Digito;
        private DataGridViewTextBoxColumn FDC;
    }
}
