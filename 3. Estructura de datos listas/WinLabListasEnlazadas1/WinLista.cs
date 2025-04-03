using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BibliotecaDeClases;
using EstructuraDeDatos;

namespace WinLabListasEnlazadas1
{
    public partial class WinLista : Form
    {
        public Lista lista;

        public WinLista()
        {
            InitializeComponent();
            lista = new Lista();
            lblResultadoNombre.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCompleto.Text;
            int edad = int.Parse(txtEdad.Text);

            Persona persona = new Persona(nombre, edad);
            lista.insertarCabezaLista(persona);

            txtNombreCompleto.Text = "";
            txtEdad.Text = "";
        }

        private void btnJoven_Click(object sender, EventArgs e)
        {
            lblResultadoNombre.Visible = true;
            Persona personaMasJoven = lista.personaMasJoven();
            lblResultadoNombre.Text = "La persona mas joven es " + personaMasJoven.Nombre + " y tiene " + personaMasJoven.Edad + " años";
        }

        private void btnViejo_Click(object sender, EventArgs e)
        {
            lblResultadoNombre.Visible = true;
            Persona personaMasVieja = lista.personaMasVieja();
            lblResultadoNombre.Text = "La persona mas vieja es " + personaMasVieja.Nombre + " y tiene " + personaMasVieja.Edad + " años";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
