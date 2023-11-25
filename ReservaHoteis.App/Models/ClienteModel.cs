namespace ReservaHoteis.App.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Documento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
