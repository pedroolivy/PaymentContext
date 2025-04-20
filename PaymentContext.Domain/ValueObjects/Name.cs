using Flunt.Validations;
using Flunt.Notifications;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications( new Contract<Notification>()
                .Requires()
                .IsGreaterOrEqualsThan(FirstName, 3, "Deve conter pelo menos 3 caractéres")
                .IsGreaterOrEqualsThan(LastName, 3, "Deve conter pelo menos 3 caractéres")
                .IsLowerOrEqualsThan(FirstName, 40, "Nome deve conter até 40 caractéres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
