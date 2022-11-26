using System.Data.SQLite;

namespace sqlite_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = ":memory:" };

            using (var connect = new SQLiteConnection(sqlConnectionSb.ToString()))
            using (var cmd = new SQLiteCommand(connect))
            {
                connect.Open();
                cmd.CommandText = "select sqlite_version()";
                Console.WriteLine($"sqlite_version: {cmd.ExecuteScalar()}");
            }
        }
    }
}