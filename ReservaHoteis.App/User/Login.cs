using ReaLTaiizor.Controls;
using ReservaHoteis.Domain.Base;
using ReservaHoteis.Domain.Entities;
using ReservaHoteis.Service.Validators;
using ReservaHoteis.App.Models;
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
        private readonly IBaseService<Usuario> _usuarioService;
        //private List<Usuario>? usuario;
        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
#if DEBUG
            txtLogin.Text = @"admin";
            txtSenha.Text = @"admin";
#endif
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var usuario = ObterUsuario(txtLogin.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }
            else
            {
                FormPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private Usuario? ObterUsuario(string login, string senha)
        {
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Email == login).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            return usuario.Senha != senha ? null : usuario;
        }

        //Cadastro 
        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = Cad_txtNome.Text;
            usuario.Email = Cad_txtEmail.Text;
            usuario.Senha = Cad_txtSenha.Text;
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
            try
            {
                var usuario = new Usuario();
                PreencheObjeto(usuario);
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
                Login_panel.Visible = true;
                Cad_panel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Reserva Hoteis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
