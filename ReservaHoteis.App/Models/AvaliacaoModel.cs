using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.App.Models
{
    public class AvaliacaoModel
    {
        public int Id { get; set; }
        public float? Nota { get; set; }
        public string? Descricao { get; set; }
        public virtual Hotel? Hotel { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}
