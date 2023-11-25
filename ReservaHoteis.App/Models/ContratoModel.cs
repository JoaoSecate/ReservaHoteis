using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.App.Models
{
    public class ContratoModel
    {
        public int Id { get; set; }
        public float? ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<ContratoServico> ContratoServico { get; set; }
    }
    public class ContratoServicoModel
    {
        public int Id { get; set; }
        public virtual Servico Servico { get; set; }
        public virtual Contrato Contrato { get; set; }
    }
}
