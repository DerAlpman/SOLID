namespace Components.SOLID.Interfaces.SingleResponsibility
{
    public interface IContactProcessor
    {
        void Process(IContactDataProvider cdp, IContactParser cp, IContactWriter cw);
    }
}