using System;
using ProjetoPetshopFix.Entities;

namespace ProjetoPetshopFix.Services
{
    class Execucao
    {
        public int CodExecucao { get; set; }
        public int Animal_CodAnimal { get; set; }
        public Animal Animal { get; set; }
        public int Servicos_CodServico { get; set; }
        //CodFuncionario vindo da classe Funcionario
        public Funcionario Funcionario { get; set; }
        public int CodVeterinario { get; set; }
        public DateTime DataExecucao { get; set; }
        public DateTime HoraExecucao { get; set; }
        public string Observacoes { get; set; }

        public Execucao()
        {
        }

        public Execucao(int codExecucao, int animal_CodAnimal, Animal animal, int servicos_CodServico, Funcionario funcionario, 
            int codVeterinario, DateTime dataExecucao, DateTime horaExecucao, string observacoes)
        {
            CodExecucao = codExecucao;
            Animal_CodAnimal = animal_CodAnimal;
            Animal = animal;
            Servicos_CodServico = servicos_CodServico;
            Funcionario = funcionario;
            CodVeterinario = codVeterinario;
            DataExecucao = dataExecucao;
            HoraExecucao = horaExecucao;
            Observacoes = observacoes;
        }
    }
}
