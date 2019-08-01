using System.Diagnostics;
using Components.SOLID.Interfaces.OpenClosed;

namespace SOLID.OpenClosed.ErrorLoggers
{
    internal class EventLogErrorLogger : IErrorLogger
    {
        public void LogError(string message)
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
