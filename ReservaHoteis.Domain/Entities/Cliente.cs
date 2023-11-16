using ReservaHoteis.Domain.Base;

namespace ReservaHoteis.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {

        }

        public Cliente(int id, string? nome, int? cpf, string? dataDeNascimento, string? email, string? senha) : base(id)
        {
            Nome = nome;
            Cpf = cpf;
            DataDeNascimento= dataDeNascimento;
            Email = email;
            Senha = senha;
            
        }

        public string? Nome { get; set; }
        public int? Cpf { get; set; }
        public string? DataDeNascimento { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}