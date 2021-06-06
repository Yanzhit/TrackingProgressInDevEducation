using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class PaymentDTO : ADTOAnswer
    {
        public int StudentId { get; set; }
        public DateTime PaymentTo { get; set; }
        public DateTime PaymentOn { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }

        public PaymentDTO()
        {
        }

        public PaymentDTO(Payment payment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Payment, PaymentDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            PaymentDTO tmpPaymentDTO = mapper.Map<PaymentDTO>(payment);

            this.StudentId = tmpPaymentDTO.StudentId;
            this.PaymentTo = tmpPaymentDTO.PaymentTo;
            this.PaymentOn = tmpPaymentDTO.PaymentOn;
            this.Amount = tmpPaymentDTO.Amount;
            this.Status = tmpPaymentDTO.Status;
        }

        public override bool Equals(object obj)
        {
            return Equals((PaymentDTO)obj);
        }

        private bool Equals(PaymentDTO other)
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
