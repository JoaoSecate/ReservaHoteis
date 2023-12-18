using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.App.Models
{
    public class ContratoModel
    {
        public int Id { get; set; }
        public float? ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public int idHotel { get; set; }
        public int idCliente { get; set; }
        public string Hotel { get; set; }
        public string Cliente { get; set; }
    }
}
