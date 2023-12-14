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
    public partial class CadastroContrato : CadastroBase
    {
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Hotel> _hotelService;
        private readonly IBaseService<Contrato> _contratoService;
        private List<Contrato>? contratos;
        private List<Cliente>? clientes; // Adicione esta linha
        private List<Hotel>? hoteis; // Adicione esta linha


        public CadastroContrato(IBaseService<Contrato> contratoService, IBaseService<Cliente> clienteService, IBaseService<Hotel> hotelService)
        {
            _clienteService = clienteService;
            _hotelService = hotelService;
            _contratoService = contratoService;
            InitializeComponent();
            CarregarCliente();
            CarregarHotel();
        }
        private void CarregarCliente()
        {
            clientes = _clienteService.Get<Cliente>().ToList();
            cboCliente.DataSource = clientes;
            cboCliente.DisplayMember = "Nome"; 
        }

        private void CarregarHotel()
        {
            hoteis = _hotelService.Get<Hotel>().ToList();
            cboHotel.DataSource = hoteis;
            cboHotel.DisplayMember = "Nome"; // Exibir o nome da cidade no ComboBox
        }

        private void PreencheObjeto(Contrato contrato)
        {
            contrato.ValorTotal = (float?)decimal.Parse(txtValor.Text);
            contrato.Data = DateTime.Now;

            // Lógica para obter o cliente e o hotel selecionados
            int clienteId, hotelId;
            if (int.TryParse(cboCliente.SelectedValue.ToString(), out clienteId) && int.TryParse(cboHotel.SelectedValue.ToString(), out hotelId))
            {
                var clienteSelecionado = clientes?.FirstOrDefault(c => c.Id == clienteId);
                var hotelSelecionado = hoteis?.FirstOrDefault(h => h.Id == hotelId);

                if (clienteSelecionado != null && hotelSelecionado != null)
                {
                    contrato.Cliente = clienteSelecionado;
                    contrato.Hotel = hotelSelecionado;
                }
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var contrato = _contratoService.GetById<Contrato>(id);
                        PreencheObjeto(contrato);
                        contrato = _contratoService.Update<Contrato, Contrato, ContratoValidator>(contrato);
                    }
                }
                else
                {
                    var contrato = new Contrato();
                    PreencheObjeto(contrato);
                    _contratoService.Add<Contrato, Contrato, ContratoValidator>(contrato);
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
                _contratoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Reserva Hoteis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            contratos = _contratoService.Get<Contrato>().ToList();
            dataGridViewConsulta.DataSource = contratos;
            dataGridViewConsulta.Columns["Data"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtValor.Text = linha?.Cells["ValorTotal"].Value.ToString();
            txtValor.Text = linha?.Cells["Data"].Value.ToString();

            // Lógica para selecionar o cliente e o hotel
            var clienteId = int.Parse(linha?.Cells["ClienteId"].Value.ToString());
            var hotelId = int.Parse(linha?.Cells["HotelId"].Value.ToString());

            cboCliente.SelectedValue = clienteId;
            cboHotel.SelectedValue = hotelId;
        }

        // Outros métodos e eventos necessários...

    }
}
