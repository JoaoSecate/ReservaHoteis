using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Contrato : BaseEntity<int>
    {
        public Contrato()
        {
            ContratoServico = new List<ContratoServico>();
        }

        public Contrato(int id, float? valorTotal, DateTime data, Hotel hotel, Cliente cliente, List<ContratoServico> contratoServico) : base(id)
        {
            ValorTotal= valorTotal;
            Data = data;
            Hotel= hotel;
            Cliente= cliente;
            ContratoServico = contratoServico;
        }

        public float? ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual List<ContratoServico> ContratoServico { get;set; }
    }
    public class ContratoServico : BaseEntity<int>
    { 
        public ContratoServico()
        {

        } 

        public ContratoServico(int id, Servico servico, Contrato contrato) :base(id)
        {
            Servico = servico;
            Contrato = contrato;
        }

        public virtual Servico Servico { get; set; }
        public virtual Contrato Contrato { get; set; }

    }
}