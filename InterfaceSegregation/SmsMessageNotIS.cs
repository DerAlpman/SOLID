using System;
using System.Collections.Generic;
using Components.SOLID.Interfaces.InterfaceSegregation;

namespace SOLID.InterfaceSegregation
{
    internal class SmsMessageNotIS : IMessageNotIS
    {
        public IList<string> SendToAddress { get; set; }

        public string MessageText { get; set; }

        public string Subject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool Send()
        {
            return true;
        }
    }
}
