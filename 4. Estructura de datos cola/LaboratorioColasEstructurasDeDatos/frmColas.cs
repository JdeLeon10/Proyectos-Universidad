using clsBibliotecaDeClases;

namespace LaboratorioColasEstructurasDeDatos
{
    public partial class frmColas : Form
    {
        clsCola Deposito = new clsCola();
        clsCola Retiro = new clsCola();
        clsCola AtencionAlCliente = new clsCola();

        public frmColas()
        {
            InitializeComponent();
        }

        private void frmColas_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbOpciones.Text == "Deposito")
            {
                Deposito.insertarElemento(txtNombre.Text);
                lbDeposito.Items.Add(txtNombre.Text);
                txtNombre.Text = "";
                cmbOpciones.SelectedIndex = -1;
            }
            else if (cmbOpciones.Text == "Retiro")
            {
                Retiro.insertarElemento(txtNombre.Text);
                lbRetiro.Items.Add(txtNombre.Text);
                txtNombre.Text = "";
                cmbOpciones.SelectedIndex = -1;
            }
            else
            {
                AtencionAlCliente.insertarElemento(txtNombre.Text);
                lbAtencionAlCliente.Items.Add(txtNombre.Text);
                txtNombre.Text = "";
                cmbOpciones.SelectedIndex = -1;
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            lbDeposito.Items.Clear();
            Deposito.retirarElemento();
            for (clsNodo posicion = Deposito.frente; posicion != null; posicion = posicion.Siguiente)
            {
                lbDeposito.Items.Add(posicion.Nombre);
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            lbRetiro.Items.Clear();
            Retiro.retirarElemento();
            for (clsNodo posicion = Retiro.frente; posicion != null; posicion = posicion.Siguiente)
            {
                lbRetiro.Items.Add(posicion.Nombre);
            }
        }

        private void btnAtencionAlCliente_Click(object sender, EventArgs e)
        {
            lbAtencionAlCliente.Items.Clear();
            AtencionAlCliente.retirarElemento();
            for (clsNodo posicion = AtencionAlCliente.frente; posicion != null; posicion = posicion.Siguiente)
            {
                lbAtencionAlCliente.Items.Add(posicion.Nombre);
            }
        }
    }
}
