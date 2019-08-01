using System.Collections.Generic;

namespace Components.SOLID.Interfaces.SingleResponsibility
{
    public interface IContactParser
    {
        IList<IContactDTO> Parse(string contactList);
    }
}
