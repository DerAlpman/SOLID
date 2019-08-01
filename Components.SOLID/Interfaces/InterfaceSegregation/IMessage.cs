using System.Collections.Generic;

namespace Components.SOLID.Interfaces.InterfaceSegregation
{
    public interface IMessage
    {
        IList<string> SendTo { get; set; }

        string MessageText { get; set; }

        bool Send();
    }
}
