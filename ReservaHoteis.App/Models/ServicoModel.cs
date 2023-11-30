using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.App.Models
{
    public class ServicoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string Tipo { get; set; }
        public float? Valor { get; set; }
        public int idHotel { get; set; }
    }
}
