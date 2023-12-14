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
    public partial class CadastroHotel : CadastroBase
    {
        private readonly IBaseService<Hotel> _hotelService;
        private readonly IBaseService<Cidade> _cidadeService; // Adicione esta linha
        private List<Hotel>? hoteis;
        private List<Cidade>? cidades;

        public CadastroHotel(IBaseService<Hotel> hotelService, IBaseService<Cidade> cidadeService) // Modifique esta linha
        {
            _hotelService = hotelService;
            _cidadeService = cidadeService; // Adicione esta linha
            InitializeComponent();
            CarregarCidades(); // Adicione esta linha para carregar as cidades ao inicializar o formulário
        }

        private void CarregarCidades()
        {
            cidades = _cidadeService.Get<Cidade>().ToList();
            cboCidade.DataSource = cidades;
            cboCidade.DisplayMember = "Nome"; // Exibir o nome da cidade no ComboBox
        }

        private void PreencheObjeto(Hotel hotel)
        {
            hotel.Nome = txtNome.Text;
            hotel.Endereco = txtEndereco.Text;

            // Lógica para obter a cidade selecionada
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
            hoteis = _hotelService.Get<Hotel>().ToList();
            dataGridViewConsulta.DataSource = hoteis;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();

            // Lógica para selecionar a cidade
            var cidadeId = int.Parse(linha?.Cells["CidadeId"].Value.ToString());
            cboCidade.SelectedValue = cidadeId;
        }

        // Outros métodos e eventos necessários...

    }
}
