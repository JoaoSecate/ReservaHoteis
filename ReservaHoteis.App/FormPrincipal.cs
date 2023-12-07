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
        public static Cliente Cliente { get; set; }
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
                    //lblCliente.Text = $"Usuário: {Cliente.Nome}";
                }
            }
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
