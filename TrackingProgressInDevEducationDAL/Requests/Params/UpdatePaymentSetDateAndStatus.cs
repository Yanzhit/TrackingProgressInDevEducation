using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class UpdatePaymentSetDateAndStatus : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdatePaymentSetDateAndStatus(int id, DateTime newDate)
        {
            Type = typeof(Payments);
            Name = GetType().Name;
            Params = $"{id}, {newDate}";
        }
    }
}
