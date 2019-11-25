using System;

namespace ProjetoPetshopFix.Entities
{
    class Cliente
    {
        public int CodCliente { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Cliente()
        {
        }
    }
}
