using ReservaHoteis.App.Base;
using ReservaHoteis.Domain.Base;
using ReservaHoteis.Domain.Entities;
using ReservaHoteis.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReservaHoteis.App.Cadastros
{
    public partial class CadastroCliente : CadastroBase
    {
        private readonly IBaseService<Cliente> _clienteService;
        private List<Cliente>? clientes;

        public CadastroCliente(IBaseService<Cliente> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Documento = txtDocumento.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Reserva Hoteis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Reserva Hoteis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<Cliente>().ToList();
            dataGridViewConsulta.DataSource = clientes;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString(); ;
        }

        // Outros métodos e eventos necessários...

    }
}
