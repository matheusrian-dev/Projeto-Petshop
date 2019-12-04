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

        DataBaseConnection con = new DataBaseConnection();

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

        public void Inserir()
        {
            try
            {
                
                
                con.Conectar();
                string query = String.Format("INSERT INTO funcionario(dataCadastro, dataNascimento, nomeFuncionario, rgFuncionario, telefoneFuncionario, " +
                    "emailFuncionario, senhaFuncionario, enderecoFuncionario, cidadeFuncionario, estadoFuncionario, paisFuncionario, tipoFuncionario) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', " + 
                    "'{8}', '{9}', '{10}', {11})",
                    Convert.ToDateTime(DataCadastro).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(DataNascimento).ToString("yyyy-MM-dd"),
                    Nome, Rg, Telefone, Email, Senha, Endereco, Cidade, Estado, Pais, (int) TipoFuncionario);

                con.ExecutarComandosSql(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
        }

        public void Excluir(int codInserido)
        {
            try
            {


                con.Conectar();
                string query = String.Format("DELETE FROM funcionario WHERE codFuncionario = {0}",
                    codInserido);

                con.ExecutarComandosSql(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Desconectar();
            }
        }
    }
}
