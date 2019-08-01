using Components.SOLID.Interfaces.SingleResponsibility;

namespace SOLID.SingleResponsibility
{
    internal class ContactProcessor : IContactProcessor
    {
        public void Process(IContactDataProvider cdp, IContactParser cp, IContactWriter cw)
        {
            var providedData = cdp.Read();
            var parsedData = cp.Parse(providedData);
            cw.Write(parsedData);
        }
    }
}
