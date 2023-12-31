using ReservaHoteis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using ReservaHoteis.App.Infra;
using ReservaHoteis.App.User;
using ReservaHoteis.App.Cadastros;

namespace ReservaHoteis.App

{
    public partial class FormPrincipal : Form
    {
        public static Usuario Usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    txtNome.Text = $"{Usuario.Nome}";
                }
            }
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCliente>();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroContrato>();
        }

        private void btnAvaliações_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroAvaliacao>();
        }

        private void btnHoteis_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroHotel>();
        }

        private void btnCidades_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCidade>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
