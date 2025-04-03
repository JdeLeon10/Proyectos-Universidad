using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFArbolBinario
{
    public partial class Form1 : Form
    {
        ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arbol.insertar(new Estudiante(Int32.Parse(txtCarne.Text), txtNombre.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text = ArbolBinarioBusqueda.preorden(arbol.raizArbol());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text = ArbolBinarioBusqueda.inorden(arbol.raizArbol());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text = ArbolBinarioBusqueda.postorden(arbol.raizArbol());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
