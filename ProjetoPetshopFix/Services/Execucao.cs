using System;

namespace ProjetoPetshopFix.Services
{
    class Execucao
    {
        public int CodAgendamento { get; set; }
        public int Animal_CodAnimal { get; set; }
        public int Servicos_CodServico { get; set; }
        //CodFuncionario vindo da classe Funcionario
        public int CodVeterinario { get; set; }
        public DateTime DataExecucao { get; set; }
        public DateTime HoraExecucao { get; set; }
        public string Observacoes { get; set; }

        public Execucao()
        {
        }

    }
}
