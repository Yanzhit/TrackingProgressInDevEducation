using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class DeletePaymentById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public DeletePaymentById(int id)
        {
            Type = typeof(Payments);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
