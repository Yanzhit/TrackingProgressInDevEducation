using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Payments
    {
        public int StudentId { get; set; }
        public DateTime PaymentTo { get; set; }
        public DateTime PaymentOn { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        //public Payments()
        //{
        //    StudentId =
        //    PaymentTo =
        //    PaymentOn =
        //    Amount =
        //    Status =
        //}
    }
}
