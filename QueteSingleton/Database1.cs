namespace QueteSingleton.Database
{
    public class Database1
    {
        private DatabaseSingleton _database;

        public Database1(DatabaseSingleton database)
        {
            _database = database;
        }

        public void RequetSql1()
        {
            _database.RequetSql("SELECT * FROM tab1");
            Console.WriteLine("Requête exécutée dans Database1");
        }
    }
}
