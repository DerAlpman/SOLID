using System;
using System.Data.SqlClient;
using System.IO;

namespace SOLID.SingleResponsibility
{
    internal class CsvFileProcessorNotSR
    {
        public void Process(string filename)
        {
            TextReader tr = new StreamReader(filename);
            tr.ReadToEnd();
            tr.Close();

            var conn = new SqlConnection("server=(local);integrated security=sspi;database=SRP");
            conn.Open();

            string[] lines = tr.ToString().Split(new string[] { @"\r\l" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] columns = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var command = conn.CreateCommand();
                command.CommandText = "INSERT INTO People (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                command.Parameters.AddWithValue("@FirstName", columns[0]);
                command.Parameters.AddWithValue("@LastName", columns[1]);
                command.Parameters.AddWithValue("@Email", columns[2]);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
