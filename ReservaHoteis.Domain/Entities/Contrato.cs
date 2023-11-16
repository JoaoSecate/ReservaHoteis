using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Contrato : BaseEntity<int>
    {
        public Contrato()
        {
            Servicos = new List<Servico>();
        }

        public Contrato(int id, float? valorTotal, Hotel? hotel, Cliente? cliente) : base(id)
        {
            ValorTotal= valorTotal;
            Hotel= hotel;
            Cliente= cliente;
        }

        public float? ValorTotal { get; set; }
        public Hotel? Hotel { get; set; }
        public Cliente? Cliente { get; set; }
        public List<Servico> Servicos { get;set; }
    }
}