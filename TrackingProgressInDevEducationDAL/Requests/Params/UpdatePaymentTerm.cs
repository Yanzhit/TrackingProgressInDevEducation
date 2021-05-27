using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class UpdatePaymentTerm : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdatePaymentTerm(int id, DateTime newDate)
        {
            Type = typeof(Payments);
            Name = "UpdatePaymentTerm";
            Params = $"{id}, {newDate}";
        }
    }
}
