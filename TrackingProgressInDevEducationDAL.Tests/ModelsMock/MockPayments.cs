using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockPayments : Payments
    {
        public MockPayments(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            StudentId = studentId;
            PaymentTo = paymentTo;
            PaymentOn = paymentOn;
            Amount = amount;
            Status = status;
        }
    }
}