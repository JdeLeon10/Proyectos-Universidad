namespace WFArbolBinario.LaboratorioABB2
{
    partial class WinABB2
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
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarProyecto = new System.Windows.Forms.TextBox();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.lblCrearProyecto = new System.Windows.Forms.Label();
            this.lblDescripcionProyecto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtCrearProyecto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombre.Location = new System.Drawing.Point(12, 24);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(74, 19);
            this.lblBuscarNombre.TabIndex = 0;
            this.lblBuscarNombre.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(304, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 46);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarProyecto
            // 
            this.txtBuscarProyecto.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProyecto.Location = new System.Drawing.Point(92, 17);
            this.txtBuscarProyecto.Name = "txtBuscarProyecto";
            this.txtBuscarProyecto.Size = new System.Drawing.Size(206, 26);
            this.txtBuscarProyecto.TabIndex = 2;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.dtpFecha);
            this.groupInfo.Controls.Add(this.cmbClientes);
            this.groupInfo.Controls.Add(this.txtDescripcion);
            this.groupInfo.Controls.Add(this.txtCrearProyecto);
            this.groupInfo.Controls.Add(this.lblFechaInicio);
            this.groupInfo.Controls.Add(this.lblCliente);
            this.groupInfo.Controls.Add(this.lblDescripcionProyecto);
            this.groupInfo.Controls.Add(this.lblCrearProyecto);
            this.groupInfo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo.Location = new System.Drawing.Point(12, 58);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(413, 180);
            this.groupInfo.TabIndex = 3;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Información Proyecto";
            // 
            // lblCrearProyecto
            // 
            this.lblCrearProyecto.AutoSize = true;
            this.lblCrearProyecto.Location = new System.Drawing.Point(6, 47);
            this.lblCrearProyecto.Name = "lblCrearProyecto";
            this.lblCrearProyecto.Size = new System.Drawing.Size(74, 19);
            this.lblCrearProyecto.TabIndex = 0;
            this.lblCrearProyecto.Text = "Nombre";
            // 
            // lblDescripcionProyecto
            // 
            this.lblDescripcionProyecto.AutoSize = true;
            this.lblDescripcionProyecto.Location = new System.Drawing.Point(6, 79);
            this.lblDescripcionProyecto.Name = "lblDescripcionProyecto";
            this.lblDescripcionProyecto.Size = new System.Drawing.Size(109, 19);
            this.lblDescripcionProyecto.TabIndex = 1;
            this.lblDescripcionProyecto.Text = "Descripción";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 112);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(72, 19);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 144);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(110, 19);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // txtCrearProyecto
            // 
            this.txtCrearProyecto.Location = new System.Drawing.Point(121, 40);
            this.txtCrearProyecto.Name = "txtCrearProyecto";
            this.txtCrearProyecto.Size = new System.Drawing.Size(286, 26);
            this.txtCrearProyecto.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 72);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(286, 26);
            this.txtDescripcion.TabIndex = 5;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(121, 104);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(286, 27);
            this.cmbClientes.TabIndex = 7;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCrear.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Location = new System.Drawing.Point(12, 244);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 46);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(161, 244);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 46);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(304, 244);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 46);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(121, 137);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 26);
            this.dtpFecha.TabIndex = 8;
            // 
            // WinABB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 306);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.txtBuscarProyecto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscarNombre);
            this.Name = "WinABB2";
            this.Text = "Laboratorio Arboles ABB2";
            this.Load += new System.EventHandler(this.WinABB2_Load);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarProyecto;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDescripcionProyecto;
        private System.Windows.Forms.Label lblCrearProyecto;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCrearProyecto;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}