namespace WFArbolBinario
{
    partial class winLabABB
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
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblPorcentajeAvance = new System.Windows.Forms.Label();
            this.lblProgramadorAsignado = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtPorcentajeAvance = new System.Windows.Forms.TextBox();
            this.txtProgramadorAsignado = new System.Windows.Forms.TextBox();
            this.btnIngresarTarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesplegarTareas = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Location = new System.Drawing.Point(22, 20);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(75, 13);
            this.lblNombreTarea.TabIndex = 0;
            this.lblNombreTarea.Text = "Nombre Tarea";
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(142, 17);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(122, 20);
            this.txtNombreTarea.TabIndex = 1;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(22, 63);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 2;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblPorcentajeAvance
            // 
            this.lblPorcentajeAvance.AutoSize = true;
            this.lblPorcentajeAvance.Location = new System.Drawing.Point(22, 102);
            this.lblPorcentajeAvance.Name = "lblPorcentajeAvance";
            this.lblPorcentajeAvance.Size = new System.Drawing.Size(98, 13);
            this.lblPorcentajeAvance.TabIndex = 3;
            this.lblPorcentajeAvance.Text = "Porcentaje Avance";
            // 
            // lblProgramadorAsignado
            // 
            this.lblProgramadorAsignado.AutoSize = true;
            this.lblProgramadorAsignado.Location = new System.Drawing.Point(22, 145);
            this.lblProgramadorAsignado.Name = "lblProgramadorAsignado";
            this.lblProgramadorAsignado.Size = new System.Drawing.Size(114, 13);
            this.lblProgramadorAsignado.TabIndex = 4;
            this.lblProgramadorAsignado.Text = "Programador Asignado";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(142, 60);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(122, 20);
            this.txtDuracion.TabIndex = 5;
            // 
            // txtPorcentajeAvance
            // 
            this.txtPorcentajeAvance.Location = new System.Drawing.Point(142, 99);
            this.txtPorcentajeAvance.Name = "txtPorcentajeAvance";
            this.txtPorcentajeAvance.Size = new System.Drawing.Size(122, 20);
            this.txtPorcentajeAvance.TabIndex = 6;
            // 
            // txtProgramadorAsignado
            // 
            this.txtProgramadorAsignado.Location = new System.Drawing.Point(142, 142);
            this.txtProgramadorAsignado.Name = "txtProgramadorAsignado";
            this.txtProgramadorAsignado.Size = new System.Drawing.Size(122, 20);
            this.txtProgramadorAsignado.TabIndex = 7;
            // 
            // btnIngresarTarea
            // 
            this.btnIngresarTarea.Location = new System.Drawing.Point(25, 183);
            this.btnIngresarTarea.Name = "btnIngresarTarea";
            this.btnIngresarTarea.Size = new System.Drawing.Size(239, 23);
            this.btnIngresarTarea.TabIndex = 8;
            this.btnIngresarTarea.Text = "Ingresar Tarea";
            this.btnIngresarTarea.UseVisualStyleBackColor = true;
            this.btnIngresarTarea.Click += new System.EventHandler(this.btnIngresarTarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de Programacion de Tareas";
            // 
            // btnDesplegarTareas
            // 
            this.btnDesplegarTareas.Location = new System.Drawing.Point(25, 253);
            this.btnDesplegarTareas.Name = "btnDesplegarTareas";
            this.btnDesplegarTareas.Size = new System.Drawing.Size(239, 23);
            this.btnDesplegarTareas.TabIndex = 10;
            this.btnDesplegarTareas.Text = "Desplegar Tareas PreOrden";
            this.btnDesplegarTareas.UseVisualStyleBackColor = true;
            this.btnDesplegarTareas.Click += new System.EventHandler(this.btnDesplegarTareas_Click);
            // 
            // lstTareas
            // 
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.Location = new System.Drawing.Point(25, 283);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(239, 121);
            this.lstTareas.TabIndex = 11;
            // 
            // winLabABB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 420);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.btnDesplegarTareas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresarTarea);
            this.Controls.Add(this.txtProgramadorAsignado);
            this.Controls.Add(this.txtPorcentajeAvance);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblProgramadorAsignado);
            this.Controls.Add(this.lblPorcentajeAvance);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtNombreTarea);
            this.Controls.Add(this.lblNombreTarea);
            this.Name = "winLabABB";
            this.Text = "Laboratorio Arboles Binarios de Busqueda";
            this.Load += new System.EventHandler(this.winLabABB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblPorcentajeAvance;
        private System.Windows.Forms.Label lblProgramadorAsignado;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtPorcentajeAvance;
        private System.Windows.Forms.TextBox txtProgramadorAsignado;
        private System.Windows.Forms.Button btnIngresarTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesplegarTareas;
        private System.Windows.Forms.ListBox lstTareas;
    }
}