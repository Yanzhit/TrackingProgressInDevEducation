using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class AddNewPayment : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }
        
        public AddNewPayment(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            Type = typeof(Payments);
            Name = "AddNewPayment";
            Params = $"{studentId}, {paymentTo}, {paymentOn}, {amount}, {status}";
        }
    }
}
