using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoPetshopFix.Services
{
    class Servicos
    {
        public int CodServico { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        readonly DataBaseConnection con = new DataBaseConnection();

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

        public Servicos(string nome, string descricao, double valor)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public DataTable RetServicos()
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT * FROM servico";
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
            string query = "SELECT * FROM servico WHERE codServico = " + codInserido;
            DataTable dt = con.RetDataTable(query);
            if (dt == null)
            {
                return false;
            }
            return true;
        }

        public bool Inserir()
        {
            try
            {
                con.Conectar();
                string query = String.Format("INSERT INTO servico(nome, descricao, valor) " +
                    "VALUES('{0}', '{1}', {2})",
                    Nome,
                    Descricao,
                    Valor);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Serviço cadastrado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível inserir os dados do Serviço! \n Resumo do Erro:" +
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
                MessageBox.Show("Serviço não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("DELETE FROM servico WHERE codServico = {0}",
                    codInserido);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Serviço removido com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível excluir os dados do Serviço! \n Resumo do Erro:" +
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
            if (!BuscarCod(CodServico))
            {
                MessageBox.Show("Serviço não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("UPDATE servico SET nome = '{0}', descricao = '{1}', valor = {2}," +
                    "WHERE codServico = {3}",
                    Nome,
                    Descricao,
                    Valor,
                    CodServico);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Dados do serviço atualizados com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível modificar os dados do Serviço! \n Resumo do Erro:" +
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
