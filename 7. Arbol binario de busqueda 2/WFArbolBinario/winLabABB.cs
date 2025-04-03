using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFArbolBinario
{
    public partial class winLabABB : Form
    {
        ArbolBinarioBusqueda arbolTarea = new ArbolBinarioBusqueda();

        public winLabABB()
        {
            InitializeComponent();
        }

        private void winLabABB_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                arbolTarea.insertar(new Tarea(txtNombreTarea.Text, Int32.Parse(txtDuracion.Text), Int32.Parse(txtPorcentajeAvance.Text), txtProgramadorAsignado.Text));
                txtNombreTarea.Text = "";
                txtDuracion.Text = ""; 
                txtPorcentajeAvance.Text = "";
                txtProgramadorAsignado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesplegarTareas_Click(object sender, EventArgs e)
        {
            lstTareas.Items.Add(ArbolBinarioBusqueda.preorden(arbolTarea.raizArbol()));
        }
    }
}
