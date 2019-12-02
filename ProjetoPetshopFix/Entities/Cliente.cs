using System;

namespace ProjetoPetshopFix.Entities
{
    class Cliente
    {
        public int CodCliente { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Cliente()
        {
        }

        public Cliente(int codCliente, DateTime dataDeCadastro, DateTime dataDeNascimento, string nome, string rg, 
            string telefone, string email, string endereco, string cidade, string estado, string pais)
        {
            CodCliente = codCliente;
            DataCadastro = dataDeCadastro;
            DataNascimento = dataDeNascimento;
            Nome = nome;
            Rg = rg;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }
    }
}
