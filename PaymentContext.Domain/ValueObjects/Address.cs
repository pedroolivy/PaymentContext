using Flunt.Validations;
using Flunt.Notifications;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsGreaterOrEqualsThan(Street, 3, "Deve conter pelo menos 3 caractéres")
                .IsGreaterOrEqualsThan(Number, 3, "Deve conter pelo menos 3 caractéres")
                .IsGreaterOrEqualsThan(Neighborhood, 3, "Deve conter pelo menos 3 caractéres")
                .IsGreaterOrEqualsThan(City, 3, "Deve conter pelo menos 3 caractéres")
                .IsGreaterOrEqualsThan(State, 3, "Deve conter pelo menos 3 caractéres")
                .IsGreaterOrEqualsThan(Country, 3, "Deve conter pelo menos 3 caractéres")
                .IsGreaterOrEqualsThan(ZipCode, 3, "Deve conter pelo menos 3 caractéres")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}
