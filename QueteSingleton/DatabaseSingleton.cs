
using System.Data.SqlClient;

namespace QueteSingleton.Database
{
    public class DatabaseSingleton
    {
        private static DatabaseSingleton _databaseSingleton;
        private SqlConnection _connection;
        private static readonly object _connectionLock = new object();

        private DatabaseSingleton()
        {
            _connection = new SqlConnection("Data source=localhost;Database=singleton; User Id=sa;Password=Toto123*;");
            _connection.Open();
        }
        public static DatabaseSingleton GetInstance()
        {
            lock (_connectionLock)
            {

                if (_databaseSingleton == null)
                {

                    _databaseSingleton = new DatabaseSingleton();
                }
            }
            return _databaseSingleton;
        }

        public void RequetSql(string sql)
        {
            using (var command = new SqlCommand(sql, _connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString());
                    }
                }
            }
        }
    }

}
