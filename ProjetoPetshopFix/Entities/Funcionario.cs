using System;
using ProjetoPetshopFix.Entities.Enum;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

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

        readonly DataBaseConnection con = new DataBaseConnection();

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

        public Funcionario(DateTime dataCadastro, DateTime dataNascimento, string nome, string rg, 
            string telefone, string email, string senha, string endereco, string cidade, string estado, 
            string pais, TipoFuncionario tipoFuncionario)
        {
            DataCadastro = dataCadastro;
            DataNascimento = dataNascimento;
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

        public DataTable RetFuncionarios()
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT * FROM funcionario";
                dt = con.RetDataTable(query);
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
            return dt;
        }

        public bool Inserir()
        {
            if (ValidarCadastro(Rg, Email))
            {
                MessageBox.Show("Informações pessoais únicas já cadastradas (RG e Email)");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("INSERT INTO funcionario(dataCadastro, dataNascimento, nomeFuncionario, rgFuncionario, telefoneFuncionario, " +
                    "emailFuncionario, senhaFuncionario, enderecoFuncionario, cidadeFuncionario, estadoFuncionario, paisFuncionario, tipoFuncionario) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', " + 
                    "'{8}', '{9}', '{10}', {11})",
                    Convert.ToDateTime(DataCadastro).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(DataNascimento).ToString("yyyy-MM-dd"),
                    Nome, 
                    Rg, 
                    Telefone, 
                    Email, 
                    Senha, 
                    Endereco, 
                    Cidade, 
                    Estado, 
                    Pais, 
                    (int) TipoFuncionario);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível inserir os dados do Funcionário! \n Resumo do Erro:" + 
                    e.Message);
                return false;
            }
            finally
            {
                con.Desconectar();
            }
        }

        public bool ValidarCadastro(string rgInserido, string emailInserido)
        {
            con.Conectar();
            string query = "SELECT * FROM funcionario WHERE rgFuncionario = " + rgInserido + " OR emailFuncionario = "+ emailInserido;
            DataTable dt = con.RetDataTable(query);
            if(dt == null)
            {
                return false;
            }
            return true;
        }

        public bool BuscarCod(int codInserido)
        {
            con.Conectar();
            string query = "SELECT * FROM funcionario WHERE codInserido = " + codInserido;
            DataTable dt = con.RetDataTable(query);
            if (dt == null)
            {
                return false;
            }
            return true;
        }

        public bool Excluir(int codInserido)
        {
            if (!BuscarCod(codInserido))
            {
                MessageBox.Show("Funcionário não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("DELETE FROM funcionario WHERE codFuncionario = {0}",
                    codInserido);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Funcionário removido com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível excluir os dados do Funcionário! \n Resumo do Erro:" +
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
            if (!BuscarCod(CodFuncionario))
            {
                MessageBox.Show("Funcionário não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("UPDATE funcionario SET dataCadastro = '{0}', dataNascimento = '{1}', nomeFuncionario = '{2}', " + 
                    "rgFuncionario = '{3}', telefoneFuncionario = '{4}', emailFuncionario = '{5}', senhaFuncionario = '{6}', enderecoFuncionario = '{7}'," + 
                    " cidadeFuncionario = '{8}', estadoFuncionario = '{9}', paisFuncionario = '{10}', tipoFuncionario = {11} " +
                    "WHERE codFuncionario = {12}",
                    Convert.ToDateTime(DataCadastro).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(DataNascimento).ToString("yyyy-MM-dd"),
                    Nome, 
                    Rg, 
                    Telefone, 
                    Email, 
                    Senha, 
                    Endereco, 
                    Cidade, 
                    Estado, 
                    Pais, 
                    (int) TipoFuncionario, 
                    CodFuncionario);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Dados do funcionário atualizados com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível modificar os dados do Funcionario! \n Resumo do Erro:" +
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
