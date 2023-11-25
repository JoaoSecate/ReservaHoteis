using ReservaHoteis.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

using ReservaHoteis.App.Infra;
using ReservaHoteis.App.Outros;

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
            var login = new Login(); //ConfigureDI.ServicesProvider!.GetService<Login>();
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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
