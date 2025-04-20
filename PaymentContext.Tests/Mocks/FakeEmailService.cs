using PaymentContext.Domain.Services.cs;

namespace PaymentContext.Tests.Mocks
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string email, string subject, string body) { }
    }
}
