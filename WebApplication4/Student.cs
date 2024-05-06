namespace WebApplication4
{
    public class Student
    {
       // MySQLDBConnection connection = new MySQLDBConnection();
        IDbConnection connection;
        public Student(IDbConnection dbConnection) 
        { 
            connection = dbConnection;
        }
        public void SaveStudent()
        {
            connection.Save();
        }
    }
}
