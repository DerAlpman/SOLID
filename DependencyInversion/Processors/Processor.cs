using Components.SOLID.Interfaces.DependencyInversion;

namespace SOLID.DependencyInversion.Processors
{
    internal class Processor
    {
        private readonly ILogger _Logger;

        internal Processor(ILogger logger)
        {
            this._Logger = logger;
        }

        internal Processor()
        {
            _Logger.WriteLogMessage("Something happened.");
        }
    }
}
