using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoPetshopFix.Entities
{
    class Cliente
    {
        public int CodCliente { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        readonly DataBaseConnection con = new DataBaseConnection();

        public Cliente()
        {
        }

        public Cliente(int codCliente, DateTime dataDeCadastro, DateTime dataDeNascimento, string nome, string rg, 
            string telefone, string email, string endereco, string cidade, string estado, string pais)
        {
            CodCliente = codCliente;
            DataCadastro = dataDeCadastro;
            DataNascimento = dataDeNascimento;
            Nome = nome;
            Rg = rg;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public Cliente(DateTime dataCadastro, DateTime dataNascimento, string nome, 
            string rg, string telefone, string email, string endereco, string cidade, 
            string estado, string pais)
        {
            DataCadastro = dataCadastro;
            DataNascimento = dataNascimento;
            Nome = nome;
            Rg = rg;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public DataTable RetClientes()
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT * FROM cliente";
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

        public DataTable RetClienteEspecifico(string nome, string rg, string email)
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT * FROM cliente WHERE nomeCliente = '" + nome + "' OR rgCliente = '" + rg + "' OR emailCliente = '" + email + "'";
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
        public bool ValidarCadastro(string rgInserido, string emailInserido)
        {
            con.Conectar();
            string query = "SELECT * FROM cliente WHERE rgCliente = " + rgInserido + " OR emailCliente = " + emailInserido;
            DataTable dt = con.RetDataTable(query);
            if (dt == null)
            {
                return false;
            }
            return true;
        }

        public bool BuscarCod(int codInserido)
        {
            con.Conectar();
            string query = "SELECT * FROM cliente WHERE codInserido = " + codInserido;
            DataTable dt = con.RetDataTable(query);
            if (dt == null)
            {
                return false;
            }
            return true;
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
                string query = String.Format("INSERT INTO cliente(dataCadastroCliente, dataNascimentoCliente, nomeCliente, rgCliente, telefoneCliente, " +
                    "emailCliente,  enderecoCliente, cidadeCliente, estadoCliente, paisCliente) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', " +
                    "'{8}', '{9}')",
                    Convert.ToDateTime(DataCadastro).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(DataNascimento).ToString("yyyy-MM-dd"),
                    Nome,
                    Rg,
                    Telefone,
                    Email,
                    Endereco,
                    Cidade,
                    Estado,
                    Pais);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Cliente cadastrado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível inserir os dados do Cliente! \n Resumo do Erro:" +
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
                MessageBox.Show("Cliente não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("DELETE FROM cliente WHERE codCliente = {0}",
                    codInserido);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Cliente removido com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível excluir os dados do Cliente! \n Resumo do Erro:" +
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
            if (!BuscarCod(CodCliente))
            {
                MessageBox.Show("Cliente não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("UPDATE cliente SET dataCadastroCliente = '{0}', dataNascimentoCliente = '{1}', nomeCliente = '{2}', " +
                    "rgCliente = '{3}', telefoneCliente = '{4}', emailCliente = '{5}', enderecoCliente = '{6}'," +
                    " cidadeCliente = '{7}', estadoCliente = '{8}', paisCliente = '{9}'" +
                    "WHERE codCliente = {10}",
                    Convert.ToDateTime(DataCadastro).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(DataNascimento).ToString("yyyy-MM-dd"),
                    Nome,
                    Rg,
                    Telefone,
                    Email,
                    Endereco,
                    Cidade,
                    Estado,
                    Pais,
                    CodCliente);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Dados do cliente atualizados com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível modificar os dados do Cliente! \n Resumo do Erro:" +
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
