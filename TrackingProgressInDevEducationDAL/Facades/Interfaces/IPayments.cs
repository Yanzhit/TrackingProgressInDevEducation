using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IPayments
    {
        Payment SetNewPayment(Payment payment);
        IEnumerable<Payment> GetPaymentsByGroup();
        IEnumerable<Payment> NullifyPayments();
    }
}