using System.Collections.Generic;

namespace Components.SOLID.Interfaces.InterfaceSegregation
{
    public interface IMessageNotIS
    {
        IList<string> SendToAddress { get; set; }
        string Subject { get; set; }
        string MessageText { get; set; }
        bool Send();
    }
}
