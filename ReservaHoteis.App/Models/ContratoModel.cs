using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.App.Models
{
    public class ContratoModel
    {
        public int Id { get; set; }
        public float? ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public string? Hotel { get; set; }
        public int IdHotel { get; set; }
        public string? Cliente { get; set; }
        public int IdCliente { get; set; }
        //public List<String>? Servico { get; set; }

        //public virtual List<ContratoServico>? ContratoServico { get; set; }
    }
    public class ContratoServicoModel
    {
        public int Id { get; set; }
        public int idServico { get; set; }
        public int idContrato { get; set; }
    }
}
