using System;
using System.Data.SqlClient;
using System.IO;

namespace SOLID.SingleResponsibility
{
    internal class CsvFileProcessorRefactored
    {
        public void Process(string filename)
        {
            var csvData = ReadCsv(filename);
            var parsedData = ParseCsv(csvData);
            StoreCsvData(parsedData);
        }

        public string ReadCsv(string filename)
        {
            TextReader tr = new StreamReader(filename);
            tr.ReadToEnd();
            tr.Close();
            return tr.ToString();
        }

        public string[] ParseCsv(string csvData)
        {
            return csvData.Split(new string[] { @"\r\l" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public void StoreCsvData(string[] csvData)
        {
            var conn = new SqlConnection("server=(local);integrated security=sspi;database=SRP");
            conn.Open();
            foreach (string line in csvData)
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
