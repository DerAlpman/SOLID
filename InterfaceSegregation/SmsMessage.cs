using System.Collections.Generic;
using Components.SOLID.Interfaces.InterfaceSegregation;

namespace SOLID.InterfaceSegregation
{
    internal class SmsMessage : IMessage
    {
        public IList<string> SendTo { get; set; }

        public string MessageText { get; set; }

        public bool Send()
        {
            return true;
        }
    }
}
