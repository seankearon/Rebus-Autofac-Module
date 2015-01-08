namespace AutofacRegistration
{
    public interface IHandleMessages<T>
    {
        void Handle(T message);
    }
}