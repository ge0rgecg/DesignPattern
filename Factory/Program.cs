using Factory.Factory;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new ConnectionFactory().CriaConexao();
            IDbCommand comando = connection.CreateCommand();
            comando.CommandText ="select * from tabela";
        }
    }
}
