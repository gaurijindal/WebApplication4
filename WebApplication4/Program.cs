using WebApplication4;

IDbConnection connection = new OracleDBConnection();
Student s = new Student(connection);
s.SaveStudent();
Console.ReadLine();