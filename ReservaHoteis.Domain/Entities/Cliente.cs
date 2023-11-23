using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {

        }

        public Cliente(int id, string nome, string? documento, string email, string senha) : base(id)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            Senha = senha;
            
        }

        public string Nome { get; set; }
        public string? Documento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}