using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Servico : BaseEntity<int>
    {
        public Servico()
        {

        }

        public Servico(int id, string? nome, string? descricao, string? tipo, float? valor, Hotel? hotel) : base(id)
        {
            Nome = nome;
            Descricao= descricao;
            Tipo = tipo;
            Valor = valor;
            Hotel = hotel;
        }

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Tipo { get; set;}
        public float? Valor { get; set;}
        public Hotel? Hotel { get; set; }
    }
}