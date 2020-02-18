using System.Data.SqlClient;

namespace Dao
{
    public class ConexaoDb
    {
        private static ConexaoDb objConexaoDb = null;
        private SqlConnection con;

        private ConexaoDb(){
            con = new SqlConnection("Data Source=DESKTOP-K52NLVK\\SQLEXPRESS; Initial Catalog=Financeiro; Integrated Security=True");
        }

        public static ConexaoDb saberEstado(){
            if (objConexaoDb == null)
            {
                objConexaoDb = new ConexaoDb();
            }

            return objConexaoDb;
        }

        public SqlConnection getCon(){
            return con;
        }

        public void CloseDB(){
            objConexaoDb = null;
        }
    }
}