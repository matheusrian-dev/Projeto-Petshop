using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetshopFix.Entities
{
    class Animal
    {
        public int CodAnimal { get; set; }
        public int Cliente_CodCliente { get; set; }
        public Cliente Cliente { get; private set; }
        public string Nome { get; set; }
        public int AnoNascimento { get; set; }
        public float Peso { get; set; }
        public string Grupo { get; set; }
        public string Raca { get; set; }
        public string Genero { get; set; }
        public bool Vacinacao { get; set; }
        public string Comportamento { get; set; }

        readonly DataBaseConnection con = new DataBaseConnection();
        
        public Animal()
        {
        }

        public Animal(int codAnimal, int cliente_CodCliente, Cliente cliente, string nome, int anoNascimento, 
            float peso, string grupo, string raca, string genero, bool vacinacao, string comportamento)
        {
            CodAnimal = codAnimal;
            Cliente_CodCliente = cliente_CodCliente;
            Cliente = cliente;
            Nome = nome;
            AnoNascimento = anoNascimento;
            Peso = peso;
            Grupo = grupo;
            Raca = raca;
            Genero = genero;
            Vacinacao = vacinacao;
            Comportamento = comportamento;
        }

        public Animal(int cliente_CodCliente, Cliente cliente, string nome, int anoNascimento, float peso, string grupo, 
            string raca, string genero, bool vacinacao, string comportamento)
        {
            Cliente_CodCliente = cliente_CodCliente;
            Cliente = cliente;
            Nome = nome;
            AnoNascimento = anoNascimento;
            Peso = peso;
            Grupo = grupo;
            Raca = raca;
            Genero = genero;
            Vacinacao = vacinacao;
            Comportamento = comportamento;
        }

        public DataTable RetAnimais()
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT * FROM animal";
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

        public DataTable RetAnimalEspecifico(string nomeAnimal, string nomeDono)
        {
            DataTable dt = null;
            try
            {
                con.Conectar();
                string query = "SELECT A.* FROM animal as A INNER JOIN cliente AS C ON" +
                    "(A.Cliente_codCliente = C.codCliente) WHERE C.nome = '" + nomeDono + "' OR A.nome LIKE '" + nomeAnimal + "'";
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
            string query = "SELECT * FROM animal WHERE codAnimal = " + codInserido;
            DataTable dt = con.RetDataTable(query);
            if (dt == null)
            {
                return false;
            }
            return true;
        }

        public bool Inserir()
        {
            if (!Cliente.ValidarCadastro(Cliente.Rg, Cliente.Email) && !Cliente.BuscarCod(Cliente_CodCliente))
            {
                MessageBox.Show("Dono do pet não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("INSERT INTO animal(nomeAnimal, anoNascimento, peso, grupo, raca, " +
                    "genero, vacinacao, comportamento, cliente_codCliente) " +
                    "VALUES('{0}', {1}, {2}, '{3}', '{4}', '{5}', {6}, '{7}', {8}",
                    Nome,
                    AnoNascimento,
                    Peso,
                    Grupo,
                    Raca,
                    Genero,
                    Vacinacao,
                    Comportamento,
                    Cliente_CodCliente);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Pet cadastrado com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível inserir os dados do Pet! \n Resumo do Erro:" +
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
                MessageBox.Show("Pet não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("DELETE FROM animal WHERE codAnimal = {0}",
                    codInserido);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Pet removido com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível excluir os dados do Pet! \n Resumo do Erro:" +
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
            if (!BuscarCod(CodAnimal))
            {
                MessageBox.Show("Pet não encontrado!");
                return false;
            }
            try
            {
                con.Conectar();
                string query = String.Format("UPDATE animal SET nomeAnimal = '{0}', anoNascimento = {1}, peso = {2}, " +
                    "grupo = '{3}', raca = '{4}', genero = '{5}', vacinacao = {6}," +
                    " comportamento = '{7}', cliente_codCliente = '{8}' " +
                    "WHERE codAnimal = {9}",
                    Nome,
                    AnoNascimento,
                    Peso,
                    Grupo,
                    Raca,
                    Genero,
                    Vacinacao,
                    Comportamento,
                    Cliente_CodCliente,
                    CodAnimal);

                con.ExecutarComandosSql(query);

                MessageBox.Show("Dados do pet atualizados com sucesso!");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível modificar os dados do Pet! \n Resumo do Erro:" +
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
