using System.IO;
using Components.SOLID.Interfaces.OpenClosed;

namespace SOLID.OpenClosed.ErrorLoggers
{
    internal class TextFileErrorLogger : IErrorLogger
    {
        public void LogError(string message)
        {
            File.WriteAllText(@"C:\Users\Public\LogFolder\Errors.txt", message);
        }
    }
}
