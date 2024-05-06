namespace WebApplication4
{
    public class MySQLDBConnection : IDbConnection
    {
        public void Save()
        {
            Console.WriteLine("Inside MySQLDBConnection");
        }
    }
}
