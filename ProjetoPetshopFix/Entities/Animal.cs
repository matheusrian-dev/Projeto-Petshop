using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPetshopFix.Entities
{
    class Animal
    {
        public int CodAnimal { get; set; }

        public int Cliente_CodCliente { get; set; }
        public Cliente Cliente { get; private set; }
        public string Nome { get; set; }
        public int AnoNascimento { get; set; }
        public float Peso { get; set; }
        public string Grupo { get; set; }
        public string Raca { get; set; }
        public string Genero { get; set; }
        public bool Vacinacao { get; set; }
        public string Comportamento { get; set; }

        public Animal()
        {
        }

        public Animal(int codAnimal, int cliente_CodCliente, Cliente cliente, string nome, int anoNascimento, 
            float peso, string grupo, string raca, string genero, bool vacinacao, string comportamento)
        {
            CodAnimal = codAnimal;
            Cliente_CodCliente = cliente_CodCliente;
            Cliente = cliente;
            Nome = nome;
            AnoNascimento = anoNascimento;
            Peso = peso;
            Grupo = grupo;
            Raca = raca;
            Genero = genero;
            Vacinacao = vacinacao;
            Comportamento = comportamento;
        }
    }
}
