using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.App.Models
{
    public class AvaliacaoModel
    {
        public int Id { get; set; }
        public float? Nota { get; set; }
        public string? Descricao { get; set; }
        public int idHotel { get; set; }
        public int idCliente { get; set; }
    }
}
