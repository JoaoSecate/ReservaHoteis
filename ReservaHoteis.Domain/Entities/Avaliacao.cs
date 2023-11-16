using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Avaliacao : BaseEntity<int>
    {
        public Avaliacao()
        {

        }

        public Avaliacao(int id, string? nome, string? estado) : base(id)
        {
           
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }
    }
}