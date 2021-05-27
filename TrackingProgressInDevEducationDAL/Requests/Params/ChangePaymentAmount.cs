using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class ChangePaymentAmount : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public ChangePaymentAmount(decimal amount, int id)
        {
            Type = typeof(Payments);
            Name = "ChangePaymentAmount";
            Params = $"{amount}, {id}";
        }
    }
}
