using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataPayments
    {
        public int StudentId { get; }
        public DateTime PaymentTo { get; }
        public DateTime PaymentOn { get; }
        public decimal Amount { get; }
        public bool Status { get; }

        public DataPayments(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            StudentId = studentId;
            PaymentTo = paymentTo;
            PaymentOn = paymentOn;
            Amount = amount;
            Status = status;
        }
    }
}