namespace QueteSingleton.Database
{
    public class Database2
    {
        private DatabaseSingleton _database;

        public Database2(DatabaseSingleton database)
        {
            _database = database;
        }
        public void RequetSql2()
        {
            _database.RequetSql("Select * from tab2");
            Console.WriteLine("requet executer dans database 2");
        }
    }
}
