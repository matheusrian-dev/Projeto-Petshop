using System;

namespace ProjetoPetshopFix.Services
{
    class Servicos
    {
        public int CodServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Servicos()
        {
        }

        public Servicos(int codServico, string nome, string descricao, double valor)
        {
            CodServico = codServico;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }
    }
}
