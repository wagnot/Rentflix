using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentflix
{
    class ConectaDB
    {
        private static string serverName = "localhost";
        private static string port = "5432";
        private static string userName = "postgres";
        private static string password = "1234";
        private static string dataBaseName = "bdRentflix";

        public static NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4}", serverName, port,
                    userName, password, dataBaseName);
                NpgsqlConnection connect = new NpgsqlConnection(stgConexao);
                connect.Open();
                return connect;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
