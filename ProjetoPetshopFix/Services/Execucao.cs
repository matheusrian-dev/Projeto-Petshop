using System;
using System.Data;
using System.Windows.Forms;
using ProjetoPetshopFix.Entities;
using ProjetoPetshopFix.Entities.Enum;

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

        readonly DataBaseConnection con = new DataBaseConnection();

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

        public Execucao(int animal_CodAnimal, Animal animal, int servicos_CodServico, Funcionario funcionario, int codVeterinario, 
            DateTime dataExecucao, DateTime horaExecucao, string observacoes)
        {
            Animal_CodAnimal = animal_CodAnimal;
            Animal = animal;
            Servicos_CodServico = servicos_CodServico;
            Funcionario = funcionario;
            CodVeterinario = codVeterinario;
            DataExecucao = dataExecucao;
            HoraExecucao = horaExecucao;
            Observacoes = observacoes;
        }

        public DataTable RetExecucao()
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT * FROM execucao";
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

        public DataTable RetExecucaoEspecifico(string nomeVeterinario, string nomeAnimal)
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT E.* FROM funcionario AS F INNER JOIN execucao AS E ON" +
                    " (F.codFuncionario = E.codVeterinario) INNER JOIN animal AS A ON" +
                    "(E.animal_codAnimalExec = A.codAnimal)" +
                    " WHERE F.nomeFuncionario = '" + nomeVeterinario + "' OR A.nomeAnimal = '" + nomeAnimal + "'";
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
            string query = "SELECT * FROM execucao WHERE execucao = " + codInserido;
            DataTable dt = con.RetDataTable(query);
            if (dt == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarVeterinario(TipoFuncionario tipoFuncionario)
        {
            if (tipoFuncionario != TipoFuncionario.Veterinario)
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
                string query = String.Format("INSERT INTO execucao(animal_codAnimal, " +
                    "servico_codServico, codVeterinarioResp, dataExecucao, horaExecucao, observacoes) " +
                    "VALUES({0}, {1}, {2}, '{3}', '{4}', '{5}'",
                    Animal_CodAnimal,
                    Servicos_CodServico,
                    CodVeterinario,
                    Convert.ToDateTime(DataExecucao).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(HoraExecucao).ToString("hh:mm:ss"),
                    Observacoes);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Execução do Serviço registrada com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível registrar a execução do serviço! \n Resumo do Erro:" +
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
                MessageBox.Show("Registro da execução do serviço não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("DELETE FROM execucao WHERE codExecucao = {0}",
                    codInserido);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Registro da execução do serviço excluído com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível excluir o registro da execução do serviço! \n Resumo do Erro:" +
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
            if (!BuscarCod(CodExecucao))
            {
                MessageBox.Show("Registro da execução do serviço não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("UPDATE execucao SET animal_codAnimal = {0}, servico_codServico = {1}, codVeterinario = {2}, " +
                    "dataExecucao = '{3}', horaExecucao = '{4}', observacoes = '{5}'" +
                    "WHERE codExecucao = {6}",
                    Animal_CodAnimal,
                    Servicos_CodServico,
                    CodVeterinario,
                    Convert.ToDateTime(DataExecucao).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(HoraExecucao).ToString("hh:mm:ss"),
                    Observacoes,
                    CodExecucao);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Registro da execução do serviço atualizado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível modificar o registro da execução do serviço! \n Resumo do Erro:" +
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
