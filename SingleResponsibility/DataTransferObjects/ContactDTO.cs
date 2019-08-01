using Components.SOLID.Interfaces.SingleResponsibility;

namespace SOLID.SingleResponsibility.DataTransferObjects
{
    internal class ContactDTO : IContactDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
