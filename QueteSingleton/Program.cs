using QueteSingleton.Database;

namespace requeteSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            DatabaseSingleton databaseSingleton = DatabaseSingleton.GetInstance();

            Database1 database1=new Database1(databaseSingleton);
            database1.RequetSql1();

            Database2 database2= new Database2(databaseSingleton);
            database2.RequetSql2();
        }
    }
}
