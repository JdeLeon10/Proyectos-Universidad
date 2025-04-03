using clsLab;

namespace WinLabTorneo
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCreacionTorneo_Click(object sender, EventArgs e)
        {
            winTorneo menuTorneo = new winTorneo();
            menuTorneo.Show();
        }

        private void btnCreacionEquipo_Click(object sender, EventArgs e)
        {
            winEquipo menuEquipo = new winEquipo();
            menuEquipo.Show();
        }

        private void btnCreacionJugador_Click(object sender, EventArgs e)
        {
            winJugador menuJugador = new winJugador();
            menuJugador.Show();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            WinInformacion menuInformacion = new WinInformacion();
            menuInformacion.Show();
        }
    }
}
