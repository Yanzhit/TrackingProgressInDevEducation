using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Payment : AbstractModel
    {
        public int StudentId { get; }
        public string PaymentTo { get; }
        public string PaymentOn { get; }
        public decimal Amount { get; }
        public bool Status { get; }

        public Payment()
        {
        }

        public Payment(Payment payment) : base(payment)
        {
            StudentId = payment.StudentId;
            PaymentTo = payment.PaymentTo;
            PaymentOn = payment.PaymentOn;
            Amount = payment.Amount;
            Status = payment.Status;
        }

        public override bool Equals(object obj)
        {
            return Equals((Payment)obj);
        }

        private bool Equals(Payment other)
        {
            return Id == other.Id
                   && StudentId == other.StudentId
                   && PaymentTo == other.PaymentTo
                   && PaymentOn == other.PaymentOn
                   && Amount == other.Amount
                   && Status == other.Status;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(StudentId);
            hashCode.Add(PaymentTo);
            hashCode.Add(PaymentOn);
            hashCode.Add(Amount);
            hashCode.Add(Status);
            return hashCode.ToHashCode();
        }
    }
}
