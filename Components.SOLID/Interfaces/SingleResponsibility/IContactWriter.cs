using System.Collections.Generic;

namespace Components.SOLID.Interfaces.SingleResponsibility
{
    public interface IContactWriter
    {
        void Write(IList<IContactDTO> contactData);
    }
}
