using System;
using System.Diagnostics;

namespace SOLID.OpenClosed
{
    internal class ErrorLoggerNotOC
    {
        private readonly string _whereToLog;

        public ErrorLoggerNotOC(string whereToLog)
        {
            this._whereToLog = whereToLog.ToUpper();
        }

        public void LogError(string message)
        {
            switch (_whereToLog)
            {
                case "TEXTFILE":
                    WriteTextFile(message);
                    break;
                case "EVENTLOG":
                    WriteEventLog(message);
                    break;
                default:
                    throw new Exception("Unable to log error");
            }
        }

        private void WriteTextFile(string message)
        {
            System.IO.File.WriteAllText(@"C:\Users\Public\LogFolder\Errors.txt", message);
        }

        private void WriteEventLog(string message)
        {
            const string source = "SOLID";
            const string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }
            EventLog.WriteEntry(source, message, EventLogEntryType.Error, 1);
        }
    }
}
