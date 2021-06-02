using System;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DPayments : ADMock
    {
        public int[] StudentId { get; }
        public DateTime[] PaymentTo { get; }
        public DateTime[] PaymentOn { get; }
        public decimal[] Amount { get; }
        public bool[] Status { get; }

        public DPayments()
        {
            StudentId = DataStudentId();
            PaymentTo = DataPaymentTo();
            PaymentOn = DataPaymentOn();
            Amount = DataAmount();
            Status = DataStatus();
        }

        private int[] DataStudentId()
        {
            return new[]
            {
                1, 3, 4
            };
        }

        private DateTime[] DataPaymentTo()
        {
            return new[]
            {
                DateTime.MaxValue,
                DateTime.MinValue,
                DateTime.Now
            };
        }

        private DateTime[] DataPaymentOn()
        {
            return new[]
            {
                DateTime.Now,
                DateTime.UtcNow,
                DateTime.Now
            };
        }
        
        private decimal[] DataAmount()
        {
            return new[]
            {
                12m, 14m, 13m
            };
        }

        private bool[] DataStatus()
        {
            return new[]
            {
                true,
                true,
                false
            };
        }
    }
}