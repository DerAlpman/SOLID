using System.Collections.Generic;

namespace Components.SOLID.Interfaces.InterfaceSegregation
{
    public interface IEmailMessage
    {
        IList<string> CCTo { get; set; }

        IList<string> BCCTo { get; set; }

        IList<string> AttachementFilePaths { get; set; }

        string Subject { get; set; }
    }
}
