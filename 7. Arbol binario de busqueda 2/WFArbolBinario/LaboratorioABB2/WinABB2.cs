using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFArbolBinario.LaboratorioABB2
{
    public partial class WinABB2 : Form
    {
        ArbolBinarioBusqueda arbolBinarioBusqueda = new ArbolBinarioBusqueda();

        public WinABB2()
        {
            InitializeComponent();
        }

        private void WinABB2_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente("11111", "Jeremy", "Direccion 1"),
                new Cliente("22222", "Jeremy", "Direccion 2"),
                new Cliente("33333", "Jeremy", "Direccion 3"),
                new Cliente("44444", "Jeremy", "Direccion 4"),
                new Cliente("55555", "Jeremy", "Direccion 5")
            };
            cmbClientes.Items.AddRange(clientes.ToArray());
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            arbolBinarioBusqueda.insertar(new Proyecto(txtCrearProyecto.Text, txtDescripcion.Text, (Cliente)cmbClientes.SelectedItem, dtpFecha.Value));
            txtCrearProyecto.Text = "";
            txtDescripcion.Text = "";
            cmbClientes.Text = "";
            dtpFecha.Value = DateTime.Now;
            MessageBox.Show("Proyecto creado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreProyecto = txtCrearProyecto.Text;
            arbolBinarioBusqueda.eliminar(new Proyecto(txtCrearProyecto.Text, txtDescripcion.Text, (Cliente)cmbClientes.SelectedItem, dtpFecha.Value));
            txtCrearProyecto.Text = "";
            txtDescripcion.Text = "";
            cmbClientes.Text = "";
            dtpFecha.Value = DateTime.Now;
            MessageBox.Show("Proyecto eliminado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Proyecto proyecto = (Proyecto)arbolBinarioBusqueda.buscar(txtBuscarProyecto.Text);
            if (proyecto == null)
            {
                MessageBox.Show("El proyecto ingresado no existe");
                txtBuscarProyecto.Text = "";
            }
            else
            {
                txtCrearProyecto.Text = proyecto.nombre;
                txtDescripcion.Text = proyecto.descripcion;
                cmbClientes.Text = proyecto.cliente.ToString();
                dtpFecha.Value = proyecto.fecha;
            }
        }
    }
}
