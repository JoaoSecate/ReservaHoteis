using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Contrato : BaseEntity<int>
    {
        public Contrato()
        {

        }

        public Contrato(int id, string? nome, string? estado) : base(id)
        {
            Nome = nome;
            Estado = estado;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }
    }
}