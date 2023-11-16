using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Hotel : BaseEntity<int>
    {
        public Hotel()
        {

        }

        public Hotel(int id, string? nome, float? classificacao, string? endereco, Cidade? cidade) : base(id)
        {
            Nome = nome;
            Classificacao= classificacao;
            Endereco = endereco;
            Cidade= cidade;
        }

        public string? Nome { get; set; }
        public float? Classificacao { get; set; }
        public string? Endereco { get; set; }
        public Cidade? Cidade { get; set; }
    }
}