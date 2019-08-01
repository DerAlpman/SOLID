using System.IO;
using Components.SOLID.Interfaces.SingleResponsibility;

namespace SOLID.SingleResponsibility.DataProviders
{
    internal class CSVContactDataProvider : IContactDataProvider
    {
        private readonly string _filename;

        public CSVContactDataProvider(string filename)
        {
            _filename = filename;
        }

        public string Read()
        {
            TextReader tr = new StreamReader(_filename);
            tr.ReadToEnd();
            tr.Close();
            return tr.ToString();
        }
    }
}
