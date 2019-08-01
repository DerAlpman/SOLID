using System.Collections.Generic;
using Components.SOLID.Interfaces.InterfaceSegregation;

namespace SOLID.InterfaceSegregation
{
    internal class EmailMessage : IMessage, IEmailMessage
    {
        public IList<string> SendTo { get; set; }

        public IList<string> CCTo { get; set; }

        public IList<string> BCCTo { get; set; }

        public IList<string> AttachementFilePaths { get; set; }
        public string Subject { get; set; }

        public string MessageText { get; set; }

        public bool Send()
        {
            return true;
        }
    }
}
