using System.Collections.Generic;
using Components.SOLID.Interfaces.InterfaceSegregation;

namespace SOLID.InterfaceSegregation
{
    internal class EmailMessageNotIS : IMessageNotIS
    {
        public IList<string> SendToAddress { get; set; }

        public string Subject { get; set; }

        public string MessageText { get; set; }

        public bool Send()
        {
            return true;
        }
    }
}
