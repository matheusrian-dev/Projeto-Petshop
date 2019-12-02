using System;
using ProjetoPetshopFix.Entities.Enum;
using System.Collections.Generic;

namespace ProjetoPetshopFix.Entities
{
    class Funcionario
    {
        public int CodFuncionario { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public TipoFuncionario TipoFuncionario { get; protected set; }

        public Funcionario()
        {
        }

        public Funcionario(int codFuncionario, DateTime dataDeCadastro, DateTime dataDeNascimento, string nome, string rg, 
            string telefone, string email, string senha, string endereco, string cidade, string estado, string pais, TipoFuncionario tipoFuncionario)
        {
            CodFuncionario = codFuncionario;
            DataCadastro = dataDeCadastro;
            DataNascimento = dataDeNascimento;
            Nome = nome;
            Rg = rg;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            TipoFuncionario = tipoFuncionario;
        }

        //public List<Funcionario> RetFuncionarios()
        //{
        //}


    }
}
