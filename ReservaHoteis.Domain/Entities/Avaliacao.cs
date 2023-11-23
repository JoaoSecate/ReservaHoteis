using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Avaliacao : BaseEntity<int>
    {
        public Avaliacao()
        {

        }

        public Avaliacao(int id, float nota, string? descricao, Hotel hotel, Cliente cliente) : base(id)
        {
            Nota = nota;
            Descricao = descricao;
            Hotel = hotel;
            Cliente = cliente;
        }

        public float? Nota { get; set; }
        public string? Descricao { get; set; }
        public virtual Hotel? Hotel { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}