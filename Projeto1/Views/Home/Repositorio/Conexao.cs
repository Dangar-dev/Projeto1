using System.Data;
using MySql.Data.MySqlClient;
using System.Data

namespace Projeto1.Views.Home.Repositorio
{
    public class Conexao
    {
        public class Conexao : IDisposable
        {

            private MySqlConnection _connection;

            public Conexao(string connectionString)
            {
                _connection = new MySqlConnection(connectionString);
                _connection.Open();
            }

            public MySqlCommand MySqlCommand()
            {
                return _connection.CreateCommand();
            }

            public void Dispose()
            {
                if (_connection != null && _connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
            }
        }

    }

}

