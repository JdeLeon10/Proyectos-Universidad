//Gabriel Figueros Cardona - 0900 22 9287
//Jeremy Alejandro De Leon Roa - 0900 22 2413

using System.Windows.Forms;

namespace ProyectoFinalAutomatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvTablaTransiciones.Rows.Add("Q0"); //Creaci�n de filas de estados al momento de cargar el form
            this.dgvTablaTransiciones.Rows.Add("Q1");
            this.dgvTablaTransiciones.Rows.Add("Q2");
            this.dgvTablaTransiciones.Rows.Add("Q3");
            this.dgvTablaTransiciones.Rows.Add("Q4");
            this.dgvTablaTransiciones.Rows.Add("Q5");
            this.dgvTablaTransiciones.Rows.Add("Q6");
        }


        private void btnBloquearTabla_Click(object sender, EventArgs e)
        {
            // Alterna la propiedad ReadOnly del DataGridView para que cuando se valide una cadena no se pueda editar la tabla de transiciones
            dgvTablaTransiciones.ReadOnly = !dgvTablaTransiciones.ReadOnly;

            // Cambia el texto del bot�n seg�n el estado del DataGridView
            if (dgvTablaTransiciones.ReadOnly)
            {
                btnBloquearTabla.Text = "DESBLOQUEAR";
            }
            else
            {
                btnBloquearTabla.Text = "BLOQUEAR";
            }
        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            dgvTablaTransiciones.Rows.Clear();
            this.dgvTablaTransiciones.Rows.Add("Q0"); //Creaci�n de filas de estados al momento de limpiar el form
            this.dgvTablaTransiciones.Rows.Add("Q1");
            this.dgvTablaTransiciones.Rows.Add("Q2");
            this.dgvTablaTransiciones.Rows.Add("Q3");
            this.dgvTablaTransiciones.Rows.Add("Q4");
            this.dgvTablaTransiciones.Rows.Add("Q5");
            this.dgvTablaTransiciones.Rows.Add("Q6");
        }

        private void btnValidarCadena_Click(object sender, EventArgs e)
        {
            char[] mtzCadena = this.txtCadenaPrueba.Text.ToCharArray(); //Destructurizar en una matriz lineal la cadena ingresada para validacion
            string resultado = "";
            DataGridViewRow row = this.dgvTablaTransiciones.Rows[0]; //Leer cada columna del data grid
            for (int i = 0; i < this.txtCadenaPrueba.TextLength; i++)
            {
                if (mtzCadena[0] == '+')
                {
                    if (row.Cells["Mas"].Value != null)
                    {
                        if (row.Cells["Mas"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["Mas"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            mtzCadena = mtzCadena.Where(n => n != mtzCadena[0]).ToArray();
                            if (mtzCadena.Length > 0)
                            {
                                row = this.dgvTablaTransiciones.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["FDC"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["FDC"].Value.ToString();
                                }
                            }
                        }
                        else if (mtzCadena.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (mtzCadena[0] == '-')
                {
                    if (row.Cells["Menos"].Value != null)
                    {
                        if (row.Cells["Menos"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["Menos"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            mtzCadena = mtzCadena.Where(n => n != mtzCadena[0]).ToArray();
                            if (mtzCadena.Length > 0)
                            {
                                row = this.dgvTablaTransiciones.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["FDC"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["FDC"].Value.ToString();
                                }
                            }
                        }
                        else if (mtzCadena.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (mtzCadena[0] == '/')
                {
                    if (row.Cells["Diagonal"].Value != null)
                    {
                        if (row.Cells["Diagonal"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["Diagonal"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            mtzCadena = mtzCadena.Where(n => n != mtzCadena[0]).ToArray();
                            if (mtzCadena.Length > 0)
                            {
                                row = this.dgvTablaTransiciones.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["FDC"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["FDC"].Value.ToString();
                                }
                            }
                        }
                        else if (mtzCadena.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (mtzCadena[0] == '*')
                {
                    if (row.Cells["Multiplicador"].Value != null)
                    {
                        if (row.Cells["Multiplicador"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["Multiplicador"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            mtzCadena = mtzCadena.Where(n => n != mtzCadena[0]).ToArray();
                            if (mtzCadena.Length > 0)
                            {
                                row = this.dgvTablaTransiciones.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["FDC"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["FDC"].Value.ToString();
                                }
                            }
                        }
                        else if (mtzCadena.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (Int32.Parse(mtzCadena[0].ToString()) >= 0 && Int32.Parse(mtzCadena[0].ToString()) <= 9)
                {
                    if (row.Cells["Digito"].Value != null)
                    {
                        if (row.Cells["Digito"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["Digito"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            mtzCadena = mtzCadena.Where(n => n != mtzCadena[0]).ToArray();
                            if (mtzCadena.Length > 0)
                            {
                                row = this.dgvTablaTransiciones.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["FDC"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["FDC"].Value.ToString();
                                }
                            }
                        }
                        else if (mtzCadena.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else
                {
                    if (row.Cells["FDC"].Value == null)
                    {
                        resultado = "Error";
                    }
                    else
                    {
                        resultado = row.Cells["FDC"].Value.ToString();
                    }
                }

                if (resultado != "")
                {
                    if (resultado == "OK")
                    {
                        MessageBox.Show("La Cadena Ingresada Es Valida", "EXITO");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("La Cadena Ingresada No Es Valida", "Error");
                        break;
                    }
                }
            }
        }
    }
}
