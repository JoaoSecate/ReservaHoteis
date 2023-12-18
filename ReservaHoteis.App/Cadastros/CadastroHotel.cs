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
    public partial class CadastroHotel : CadastroBase
    {
        private readonly IBaseService<Hotel> _hotelService;
        private readonly IBaseService<Cidade> _cidadeService;
        private readonly IBaseService<Avaliacao> _avaliacaoService;
        private List<HotelModel>? hoteis;
        private List<Cidade>? cidades;

        public CadastroHotel(IBaseService<Hotel> hotelService, 
                            IBaseService<Cidade> cidadeService,
                            IBaseService<Avaliacao> avaliacaoService) 
        {
            _hotelService = hotelService;
            _cidadeService = cidadeService; 
            _avaliacaoService= avaliacaoService;
            InitializeComponent();
            CarregarCidades();
        }

        private void CarregarCidades()
        {
            cidades = _cidadeService.Get<Cidade>().ToList();
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";
            cboCidade.DataSource = cidades;            
        }

        private void PreencheObjeto(Hotel hotel)
        {
            hotel.Nome = txtNome.Text;
            hotel.Endereco = txtEndereco.Text;

            if (cboCidade.SelectedItem != null)
            {
                hotel.Cidade = (Cidade)cboCidade.SelectedItem;
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
                        var hotel = _hotelService.GetById<Hotel>(id);
                        PreencheObjeto(hotel);
                        hotel = _hotelService.Update<Hotel, Hotel, HotelValidator>(hotel);
                    }
                }
                else
                {
                    var hotel = new Hotel();
                    PreencheObjeto(hotel);
                    _hotelService.Add<Hotel, Hotel, HotelValidator>(hotel);
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
                _hotelService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Reserva Hoteis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            hoteis = _hotelService.Get<HotelModel>(new[] { "Cidade" }).ToList();
            foreach(var hot in hoteis)
            {
                hot.Classificacao = _avaliacaoService.Get<Avaliacao>(new[] { "Hotel" }).Where(x => x.Hotel!.Id == hot.Id)
                    .Select(y =>y.Nota).Average();
            }
            dataGridViewConsulta.DataSource = hoteis;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["idCidade"]!.Visible= false;
            dataGridViewConsulta.Columns["Classificacao"].DefaultCellStyle.Format = "N2";
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();

            // Selecionar a cidade
            var cidadeId = int.Parse(linha?.Cells["idCidade"].Value.ToString());
            cboCidade.SelectedValue = cidadeId;
        }
    }
}
