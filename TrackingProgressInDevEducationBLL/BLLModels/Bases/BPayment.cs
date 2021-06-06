using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BPayment : AbstractBModel
    {
        public int StudentId { get; set; }
        public DateTime PaymentTo { get; set; }
        public DateTime PaymentOn { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }

        public BPayment()
        {
        }

        public BPayment(Payment payment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Payment, BPayment>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BPayment tmpBPayment = mapper.Map<BPayment>(payment);

            this.StudentId = tmpBPayment.StudentId;
            this.PaymentTo = tmpBPayment.PaymentTo;
            this.PaymentOn = tmpBPayment.PaymentOn;
            this.Amount = tmpBPayment.Amount;
            this.Status = tmpBPayment.Status;
        }

        public override bool Equals(object obj)
        {
            return Equals((BPayment)obj);
        }

        private bool Equals(BPayment other)
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
