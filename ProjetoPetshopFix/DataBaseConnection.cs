using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoPetshopFix
{
    class DataBaseConnection
    {
        private MySqlConnection con;

        private MySqlDataAdapter da;

        private MySqlCommand cmd;

        private DataTable dt;

        private string server = "localhost";
        private string database = "dbprojetopetshopfix";
        private string uid = "developer";
        private string password = "Matheusrian99838819@";



        public void Conectar()
        {
            if (con != null)
                con.Close();

            string conStr = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "Erro ao abrir conexão");
            }
        }

        public void Desconectar()
        {

            string conStr = String.Format("server={0};" +
                " Initial Catalog={1};" +
                "Integrated Security=SSPI", server, database);

            try
            {
                con = new MySqlConnection(conStr);
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                    "Erro ao fechar conexão."
                    );
            }
        }

        public void ExecutarComandosSql(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
        }

        public DataTable RetDataTable(string sql)
        {
            try
            {
                dt = new DataTable();


                da = new MySqlDataAdapter(sql, con);


                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message +
                   "Erro ao retornar DataTable.");
            }

        }
    }
}
