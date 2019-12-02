using System;
using ProjetoPetshopFix.Entities;

namespace ProjetoPetshopFix.Services
{
    class Agendamento
    {
        public int CodAgendamento { get; set; }
        public int Animal_CodAnimal { get; set; }
        public Animal Animal { get; set; }
        public int Servicos_CodServico { get; set; }
        public int CodVeterinario { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime HoraPrevista { get; set; }
        public string Observacoes { get; set; }

        public Agendamento()
        {
        }

        public Agendamento(int codAgendamento, int animal_CodAnimal, Animal animal, int servicos_CodServico, int codVeterinario, 
            Funcionario funcionario, DateTime dataPrevista, DateTime horaPrevista, string observacoes)
        {
            CodAgendamento = codAgendamento;
            Animal_CodAnimal = animal_CodAnimal;
            Animal = animal;
            Servicos_CodServico = servicos_CodServico;
            CodVeterinario = codVeterinario;
            Funcionario = funcionario;
            DataPrevista = dataPrevista;
            HoraPrevista = horaPrevista;
            Observacoes = observacoes;
        }
    }
}
