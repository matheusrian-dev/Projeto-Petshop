using System;
using System.Data;
using System.Windows.Forms;
using ProjetoPetshopFix.Entities;
using ProjetoPetshopFix.Entities.Enum;

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

        readonly DataBaseConnection con = new DataBaseConnection();

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

        public Agendamento(int animal_CodAnimal, Animal animal, int servicos_CodServico, int codVeterinario, Funcionario funcionario, 
            DateTime dataPrevista, DateTime horaPrevista, string observacoes)
        {
            Animal_CodAnimal = animal_CodAnimal;
            Animal = animal;
            Servicos_CodServico = servicos_CodServico;
            CodVeterinario = codVeterinario;
            Funcionario = funcionario;
            DataPrevista = dataPrevista;
            HoraPrevista = horaPrevista;
            Observacoes = observacoes;
        }

        public DataTable RetAgendamento()
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT * FROM agendamento";
                dt = con.RetDataTable(query);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
            return dt;
        }

        public bool BuscarCod(int codInserido)
        {
            con.Conectar();
            string query = "SELECT * FROM agendamento WHERE codAgendamento = " + codInserido;
            DataTable dt = con.RetDataTable(query);
            if (dt == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarVeterinario(TipoFuncionario tipoFuncionario)
        {
            if(tipoFuncionario != TipoFuncionario.Veterinario)
            {
                return false;
            }
            return true;
        }

        public bool Inserir()
        {
            if (!ValidarVeterinario(Funcionario.TipoFuncionario))
            {
                MessageBox.Show("Funcionário selecionado não é um veterinário!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("INSERT INTO agendamento(animal_codAnimal, " +
                    "servico_codServico, codVeterinario, dataPrevista, horaPrevista, observacoes) " +
                    "VALUES({0}, {1}, {2}, '{3}', '{4}', '{5}'",
                    Animal_CodAnimal,
                    Servicos_CodServico,
                    CodVeterinario,
                    Convert.ToDateTime(DataPrevista).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(HoraPrevista).ToString("hh:mm:ss"),
                    Observacoes);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Agendamento realizado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível agendar o serviço! \n Resumo do Erro:" +
                    e.Message);
                return false;
            }
            finally
            {
                con.Desconectar();
            }
        }

        public bool Excluir(int codInserido)
        {
            if (!BuscarCod(codInserido))
            {
                MessageBox.Show("Agendamento não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("DELETE FROM agendamento WHERE codAgendamento = {0}",
                    codInserido);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Agendamento cancelado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível cancelar o agendamento! \n Resumo do Erro:" +
                    e.Message);
                return false;
            }
            finally
            {
                con.Desconectar();
            }
        }

        public bool Editar()
        {
            if (!BuscarCod(CodAgendamento))
            {
                MessageBox.Show("Agendamento não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("UPDATE agendamento SET animal_codAnimal = {0}, servico_codServico = {1}, codVeterinario = {2}, " +
                    "dataPrevista = '{3}', horaPrevista = '{4}', observacoes = '{5}'" +
                    "WHERE codAgendamento = {6}",
                    Animal_CodAnimal,
                    Servicos_CodServico,
                    CodVeterinario,
                    Convert.ToDateTime(DataPrevista).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(HoraPrevista).ToString("hh:mm:ss"),
                    Observacoes,
                    CodAgendamento);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Agendamento atualizado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível modificar o agendamento! \n Resumo do Erro:" +
                    e.Message);
                return false;
            }
            finally
            {
                con.Desconectar();
            }
        }
    }
}
