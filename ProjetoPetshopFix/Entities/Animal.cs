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
    }
}
