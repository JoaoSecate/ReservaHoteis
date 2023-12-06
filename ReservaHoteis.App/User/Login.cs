using ReservaHoteis.Domain.Base;
using ReservaHoteis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaHoteis.App.User
{
    public partial class Login : Form
    {
        //private readonly IBaseService<Cliente> _clienteService;
        public Login(/*IBaseService<Cliente> clienteService*/)
        {
            //_clienteService = clienteService;
            InitializeComponent();
#if DEBUG
            //txtLogin.Text = @"admin";
            //txtSenha.Text = @"admin";
#endif
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //TODO Logar Usuario
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = false;
            Cad_panel.Visible = true;
        }

        private void Cad_btnVoltar_Click(object sender, EventArgs e)
        {
            Login_panel.Visible = true;
            Cad_panel.Visible = false;
        }

        private void Cad_btnConf_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
