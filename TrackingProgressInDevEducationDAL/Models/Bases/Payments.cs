using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Payments : IModels
    {
        public int StudentId { get; set; }
        public DateTime PaymentTo { get; set; }
        public DateTime PaymentOn { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Payments)obj);
        }

        private bool Equals(Payments other)
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
