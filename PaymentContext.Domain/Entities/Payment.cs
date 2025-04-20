using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public Payment(
            DateTime paidDate, 
            DateTime expireDate, 
            string total, string 
            totalPaid, 
            string payer, 
            Document document,
            Address address,
            Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Total { get; set; }
        public string TotalPaid { get; set; }
        public string Payer { get; set; }
        public Document Document { get; set; }
        public Address Address { get; set; }
        public Email Email { get; set; }
    }
}
