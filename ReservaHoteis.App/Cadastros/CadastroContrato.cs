using ReservaHoteis.App.Base;
using ReservaHoteis.App.Models;
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
        private List<ContratoModel>? contratos;
        private List<Cliente>? clientes; 
        private List<Hotel>? hoteis; 


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
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = clientes;

        }

        private void CarregarHotel()
        {
            hoteis = _hotelService.Get<Hotel>().ToList();
            cboHotel.ValueMember = "Id";
            cboHotel.DisplayMember = "Nome";
            cboHotel.DataSource = hoteis;
        }

        private void PreencheObjeto(Contrato contrato)
        {
            contrato.ValorTotal = (float?)decimal.Parse(txtValor.Text);
            contrato.Data = DateTime.Now;

            // Obter o cliente e o hotel selecionados
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
            contratos = _contratoService.Get<ContratoModel>(new[] { "Hotel", "Cliente" }).ToList();
            //TODO
            dataGridViewConsulta.DataSource = contratos;
            dataGridViewConsulta.Columns["Data"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["idHotel"]!.Visible = false;
            dataGridViewConsulta.Columns["idCliente"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtValor.Text = linha?.Cells["ValorTotal"].Value.ToString();
            txtValor.Text = linha?.Cells["Data"].Value.ToString();

            // Selecionar o cliente e o hotel
            var clienteId = int.Parse(linha?.Cells["ClienteId"].Value.ToString());
            var hotelId = int.Parse(linha?.Cells["HotelId"].Value.ToString());

            cboCliente.SelectedValue = clienteId;
            cboHotel.SelectedValue = hotelId;
        }
    }
}
