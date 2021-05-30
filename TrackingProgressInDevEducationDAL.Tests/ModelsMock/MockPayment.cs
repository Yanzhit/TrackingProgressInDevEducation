using System;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockPayment : Payment
    {
        public MockPayment(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            StudentId = studentId;
            PaymentTo = paymentTo;
            PaymentOn = paymentOn;
            Amount = amount;
            Status = status;
        }
    }
}