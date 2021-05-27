using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class GetAllPaymentsByGroup : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetAllPaymentsByGroup(int group)
        {
            Type = typeof(Payments);
            Name = "GetAllPaymentsByGroup";
            Params = $"{group}";
        }
    }
}
