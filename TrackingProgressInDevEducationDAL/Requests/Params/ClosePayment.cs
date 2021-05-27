using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class ClosePayment : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public ClosePayment(DateTime date, int id)
        {
            Type = typeof(Payments);
            Name = "ClosePayment";
            Params = $"{date}, {id}";
        }
    }
}
