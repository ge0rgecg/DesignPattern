using System.Data;
using System.Data.SqlClient;

namespace Factory.Factory
{
    public class ConnectionFactory
    {

        public IDbConnection CriaConexao()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=sa;password=sa;server=localhost;database=banco";
            conexao.Open();
            return conexao;
        }
    }
}
