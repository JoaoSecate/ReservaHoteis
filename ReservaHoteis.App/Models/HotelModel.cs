using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.App.Models
{
    public class HotelModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float? Classificacao { get; set; }
        public string Endereco { get; set; }
        public int idCidade { get; set; }
        public string Cidade { get; set; }  
    }
}
