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
    public partial class CadastroAvaliacao : CadastroBase
    {
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Hotel> _hotelService;
        private readonly IBaseService<Avaliacao> _avaliacaoService;
        private List<Avaliacao>? avaliacoes;
        private List<Cliente>? clientes; 
        private List<Hotel>? hoteis; 

        public CadastroAvaliacao(IBaseService<Avaliacao> avaliacaoService, IBaseService<Cliente> clienteService, IBaseService<Hotel> hotelService)
        {
            _avaliacaoService = avaliacaoService;
            _clienteService = clienteService;
            _hotelService = hotelService;
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

        private void PreencheObjeto(Avaliacao avaliacao)
        {
            avaliacao.Nota = (float?)decimal.Parse(txtNota.Text);
            avaliacao.Descricao = txtDescricao.Text;

            int clienteId, hotelId;
            if (int.TryParse(cboCliente.SelectedValue.ToString(), out clienteId) && int.TryParse(cboHotel.SelectedValue.ToString(), out hotelId))
            {
                var clienteSelecionado = clientes?.FirstOrDefault(c => c.Id == clienteId);
                var hotelSelecionado = hoteis?.FirstOrDefault(h => h.Id == hotelId);

                if (clienteSelecionado != null && hotelSelecionado != null)
                {
                    avaliacao.Cliente = clienteSelecionado;
                    avaliacao.Hotel = hotelSelecionado;
                }
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtNota.Text, out var id))
                    {
                        var avaliacao = _avaliacaoService.GetById<Avaliacao>(id);
                        PreencheObjeto(avaliacao);
                        avaliacao = _avaliacaoService.Update<Avaliacao, Avaliacao, AvaliacaoValidator>(avaliacao);
                    }
                }
                else
                {
                    var avaliacao = new Avaliacao();
                    PreencheObjeto(avaliacao);
                    _avaliacaoService.Add<Avaliacao, Avaliacao, AvaliacaoValidator>(avaliacao);
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
                _avaliacaoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Reserva Hoteis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            avaliacoes = _avaliacaoService.Get<Avaliacao>().ToList();
            dataGridViewConsulta.DataSource = avaliacoes;
            dataGridViewConsulta.Columns["Nota"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtNota.Text = linha?.Cells["Id"].Value.ToString();
            txtNota.Text = linha?.Cells["Nota"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();

            // Lógica para selecionar o cliente e o hotel
            var clienteId = int.Parse(linha?.Cells["ClienteId"].Value.ToString());
            var hotelId = int.Parse(linha?.Cells["HotelId"].Value.ToString());

            cboCliente.SelectedValue = clienteId;
            cboHotel.SelectedValue = hotelId;
        }

        // Outros métodos e eventos necessários...

    }
}
