using Biblioteca_de_Clases.Colas;
using Biblioteca_de_Clases.Listas;
using Biblioteca_de_Clases.Pilas;

namespace WinProyectoListasPilasColas_GuerraCartas
{
    public partial class winJuego : Form
    {
        clsCola colaValoresBarajeados = new clsCola();
        clsPila pilaJugador1 = new clsPila();
        clsPila pilaJugador2 = new clsPila();
        clsPila pilaJugador3 = new clsPila();
        clsLista listaJugador1 = new clsLista();
        clsLista listaJugador2 = new clsLista();
        clsLista listaJugador3 = new clsLista();
        clsLista listaPozo = new clsLista();

        public winJuego()
        {
            InitializeComponent();
            lblColaLlena.Visible = false;
        }

        private void btnBarajear_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int valor = random.Next(1, 14);
                colaValoresBarajeados.insertarElementoCola(valor);
            }
            lblColaLlena.Visible = true;
            lblColaLlena.Text = "Cola llena";
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            int k = 0;
            Boolean variable = colaValoresBarajeados.colaVacia();
            if (variable)
            {
                lblColaLlena.Visible = true;
                lblColaLlena.Text = "Primero debe barajear las cartas";
            }
            for (clsNodoCola ultimo = colaValoresBarajeados.frente; ultimo != null; ultimo = ultimo.Siguiente)
            {
                if (k == 0)
                {
                    txt1Jugador1.Text = ultimo.carta.ToString();
                    pilaJugador1.insertarElementoPila(ultimo.carta);
                }
                else if (k == 1)
                {
                    txt1Jugador2.Text = ultimo.carta.ToString();
                    pilaJugador2.insertarElementoPila(ultimo.carta);
                }
                else if (k == 2)
                {
                    txt1Jugador3.Text = ultimo.carta.ToString();
                    pilaJugador3.insertarElementoPila(ultimo.carta);
                }
                else if (k == 3)
                {
                    txt2Jugador1.Text = ultimo.carta.ToString();
                    pilaJugador1.insertarElementoPila(ultimo.carta);
                }
                else if (k == 4)
                {
                    txt2Jugador2.Text = ultimo.carta.ToString();
                    pilaJugador2.insertarElementoPila(ultimo.carta);
                }
                else if (k == 5)
                {
                    txt2Jugador3.Text = ultimo.carta.ToString();
                    pilaJugador3.insertarElementoPila(ultimo.carta);
                }
                else if (k == 6)
                {
                    txt3Jugador1.Text = ultimo.carta.ToString();
                    pilaJugador1.insertarElementoPila(ultimo.carta);
                }
                else if (k == 7)
                {
                    txt3Jugador2.Text = ultimo.carta.ToString();
                    pilaJugador2.insertarElementoPila(ultimo.carta);
                }
                else if (k == 8)
                {
                    txt3Jugador3.Text = ultimo.carta.ToString();
                    pilaJugador3.insertarElementoPila(ultimo.carta);
                }
                else if (k == 9)
                {
                    txt4Jugador1.Text = ultimo.carta.ToString();
                    pilaJugador1.insertarElementoPila(ultimo.carta);
                }
                else if (k == 10)
                {
                    txt4Jugador2.Text = ultimo.carta.ToString();
                    pilaJugador2.insertarElementoPila(ultimo.carta);
                }
                else if (k == 11)
                {
                    txt4Jugador3.Text = ultimo.carta.ToString();
                    pilaJugador3.insertarElementoPila(ultimo.carta);
                }
                else if (k == 12)
                {
                    txt5Jugador1.Text = ultimo.carta.ToString();
                    pilaJugador1.insertarElementoPila(ultimo.carta);
                }
                else if (k == 13)
                {
                    txt5Jugador2.Text = ultimo.carta.ToString();
                    pilaJugador2.insertarElementoPila(ultimo.carta);
                }
                else if (k == 14)
                {
                    txt5Jugador3.Text = ultimo.carta.ToString();
                    pilaJugador3.insertarElementoPila(ultimo.carta);
                }
                colaValoresBarajeados.retirarElementoCola();
                k++;
            }
        }

        int j = 5;
        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (pilaJugador1.pilaVacia() || pilaJugador2.pilaVacia() || pilaJugador3.pilaVacia())
            {
                lblColaLlena.Visible = true;
                lblColaLlena.Text = "Los jugadores no tienen cartas";
                return;
            }
            else
            {
                int cartasJugador1 = pilaJugador1.cimaPila();
                int cartasJugador2 = pilaJugador2.cimaPila();
                int cartasJugador3 = pilaJugador3.cimaPila();
                if (cartasJugador1 > cartasJugador2 && cartasJugador1 > cartasJugador3)
                {
                    listaJugador1.insertarElementoCabezaLista(cartasJugador1);
                    listaJugador1.insertarElementoCabezaLista(cartasJugador2);
                    listaJugador1.insertarElementoCabezaLista(cartasJugador3);
                }
                else if (cartasJugador2 > cartasJugador1 && cartasJugador2 > cartasJugador3)
                {
                    listaJugador2.insertarElementoCabezaLista(cartasJugador1);
                    listaJugador2.insertarElementoCabezaLista(cartasJugador2);
                    listaJugador2.insertarElementoCabezaLista(cartasJugador3);
                }
                else if (cartasJugador3 > cartasJugador1 && cartasJugador3 > cartasJugador2)
                {
                    listaJugador3.insertarElementoCabezaLista(cartasJugador1);
                    listaJugador3.insertarElementoCabezaLista(cartasJugador2);
                    listaJugador3.insertarElementoCabezaLista(cartasJugador3);
                }
                else if (cartasJugador1 == cartasJugador2 && cartasJugador1 == cartasJugador3 && cartasJugador2 == cartasJugador3)
                {
                    listaJugador1.insertarElementoCabezaLista(cartasJugador1);
                    listaJugador2.insertarElementoCabezaLista(cartasJugador2);
                    listaJugador3.insertarElementoCabezaLista(cartasJugador3);
                }
                else if (cartasJugador1 == cartasJugador2 && cartasJugador1 != cartasJugador3 && cartasJugador2 != cartasJugador3)
                {
                    listaJugador1.insertarElementoCabezaLista(cartasJugador1);
                    listaJugador2.insertarElementoCabezaLista(cartasJugador2);
                    listaPozo.insertarElementoCabezaLista(cartasJugador3);
                }
                else if (cartasJugador1 == cartasJugador3 && cartasJugador1 != cartasJugador2 && cartasJugador2 != cartasJugador3)
                {
                    listaJugador1.insertarElementoCabezaLista(cartasJugador1);
                    listaJugador3.insertarElementoCabezaLista(cartasJugador3);
                    listaPozo.insertarElementoCabezaLista(cartasJugador2);
                }
                else if (cartasJugador2 == cartasJugador3 && cartasJugador2 != cartasJugador1 && cartasJugador3 != cartasJugador1)
                {
                    listaJugador1.insertarElementoCabezaLista(cartasJugador2);
                    listaJugador3.insertarElementoCabezaLista(cartasJugador3);
                    listaPozo.insertarElementoCabezaLista(cartasJugador1);
                }
                if (j == 5)
                {
                    txt5Jugador1.Visible = false;
                    pilaJugador1.retirarElementoPila();
                    txt5Jugador2.Visible = false;
                    pilaJugador2.retirarElementoPila();
                    txt5Jugador3.Visible = false;
                    pilaJugador3.retirarElementoPila();
                }
                else if (j == 4)
                {
                    txt4Jugador1.Visible = false;
                    pilaJugador1.retirarElementoPila();
                    txt4Jugador2.Visible = false;
                    pilaJugador2.retirarElementoPila();
                    txt4Jugador3.Visible = false;
                    pilaJugador3.retirarElementoPila();
                }
                else if (j == 3)
                {
                    txt3Jugador1.Visible = false;
                    pilaJugador1.retirarElementoPila();
                    txt3Jugador2.Visible = false;
                    pilaJugador2.retirarElementoPila();
                    txt3Jugador3.Visible = false;
                    pilaJugador3.retirarElementoPila();
                }
                else if (j == 2)
                {
                    txt2Jugador1.Visible = false;
                    pilaJugador1.retirarElementoPila();
                    txt2Jugador2.Visible = false;
                    pilaJugador2.retirarElementoPila();
                    txt2Jugador3.Visible = false;
                    pilaJugador3.retirarElementoPila();
                }
                else if (j == 1)
                {
                    txt1Jugador1.Visible = false;
                    pilaJugador1.retirarElementoPila();
                    txt1Jugador2.Visible = false;
                    pilaJugador2.retirarElementoPila();
                    txt1Jugador3.Visible = false;
                    pilaJugador3.retirarElementoPila();
                }
                else if (j == 0)
                {
                lblColaLlena.Text = "Ya no hay cartas disponibles";
                }
                j--;
            }
        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            int total1 = listaJugador1.totalCartas();
            int total2 = listaJugador2.totalCartas();
            int total3 = listaJugador3.totalCartas();

            if (total1 > total2 && total1 > total3)
            {
                lblColaLlena.Text = "El jugador 1 ha ganado con " + total1 + " puntos";
            }
            else if (total2 > total1 && total2 > total3)
            {
                lblColaLlena.Text = "El jugador 2 ha ganado con " + total2 + " puntos";
            }
            else if (total3 > total1 && total3 > total2)
            {
                lblColaLlena.Text = "El jugador 3 ha ganado con " + total3 + " puntos";
            }
            else
            {
                lblColaLlena.Text = ("Ha ocurrido un empate entre los 3 jugadores");
            }
        }
    }
}
