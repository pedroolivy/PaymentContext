using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Hendlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand
            {
                FirstName = "João",
                LastName = "Pereira",
                Document = "32165498700",
                Email = "joao.pereira@email.com",
                BarCode = "987654321",
                BoletoNumber = "7894561230",
                PaymentNumber = "321321",
                PaidDate = DateTime.Now,
                ExpireDate = DateTime.Now.AddMonths(1),
                Total = 120,
                TotalPaid = 120,
                Payer = "Pereira Serviços LTDA",
                PayerDocument = "98765432100",
                PayerDocumentType = EDocumentType.CPF,
                PayerEmail = "financeiro@pereiraservicos.com",
                Street = "Rua das Palmeiras",
                Number = "321",
                Neighborhood = "Centro",
                City = "Campinas",
                State = "SP",
                Country = "BR",
                ZipCode = "13010010"
            };

            handler.Handler(command);
            Assert.AreEqual(false, handler.IsValid);
        }
    }
}
