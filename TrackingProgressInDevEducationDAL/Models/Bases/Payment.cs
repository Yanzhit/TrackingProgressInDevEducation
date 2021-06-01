using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Payment : AbstractModel
    {
        public int StudentId { get; set; }
        public DateTime PaymentTo { get; set; }
        public DateTime PaymentOn { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }

        public Payment()
        {
        }

        public Payment
        (
            int studentId,
            DateTime paymentTo,
            DateTime paymentOn,
            decimal amount,
            bool status
        )
        {
            StudentId = studentId;
            PaymentTo = paymentTo;
            PaymentOn = paymentOn;
            Amount = amount;
            Status = status;
        }

        public override bool Equals(object obj)
        {
            return Equals((Payment)obj);
        }

        private bool Equals(Payment other)
        {
            return StudentId == other.StudentId
                   && PaymentTo.Equals(other.PaymentTo)
                   && PaymentOn.Equals(other.PaymentOn)
                   && Amount == other.Amount
                   && Status == other.Status;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId, PaymentTo, PaymentOn, Amount, Status);
        }
    }
}
