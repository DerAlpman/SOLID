using SOLID.DependencyInversion.Loggers;

namespace SOLID.DependencyInversion.Processors

{
    internal class ProcessorNotDI
    {
        internal void Process()
        {
            var logger = new TextLoggerNotDI();
            logger.WriteLogMessage("Something happened");
        }
    }
}
