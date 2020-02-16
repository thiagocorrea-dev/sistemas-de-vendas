using System.Data.SqlClient;

namespace Dao
{
    public class ConexaoDB
    {
        // Criação das variáveis para conexão com o banco de dados
        private static ConexaoDB objConexaoDB = null;
        private SqlConnection con;

        // Criação do construtor
        private ConexaoDB()
        {
            con = new SqlConnection("Data Source=DESKTOP-K52NLVK\\SQLEXPRESS; Initial Catalog=Financeiro; Integrated Security=True");
        }

        public static ConexaoDB saberEstado()
        {
            if (objConexaoDB == null)
            {
                objConexaoDB = new ConexaoDB();
            }

            return objConexaoDB;
        }

        // Pegar a conexão
        public SqlConnection GetConnection()
        {
            return con;
        }

        public void CloseDB()
        {
            objConexaoDB = null;
        }
    }
}