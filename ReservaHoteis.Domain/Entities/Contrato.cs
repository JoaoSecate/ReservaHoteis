using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Contrato : BaseEntity<int>
    {
        public Contrato()
        {
   
        }

        public Contrato(int id, float? valorTotal, DateTime data, Hotel hotel, Cliente cliente) : base(id)
        {
            ValorTotal= valorTotal;
            Data = data;
            Hotel= hotel;
            Cliente= cliente;
  
        }

        public float? ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
 
}