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
    public partial class Form2 : Form
    {
        ArbolAVL arbol = new ArbolAVL();

        public Form2()
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
                arbol.insertar(new Estudiante2(Int32.Parse(txtCarne.Text), txtNombre.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text = ArbolAVL.preorden(arbol.raizArbol());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text = ArbolAVL.inorden(arbol.raizArbol());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text = ArbolAVL.postorden(arbol.raizArbol());
        }
    }
}
