namespace PaymentContext.Domain.Services.cs
{
    public interface IEmailService
    {
        void Send(string to, string email, string subject, string body);
    }
}
