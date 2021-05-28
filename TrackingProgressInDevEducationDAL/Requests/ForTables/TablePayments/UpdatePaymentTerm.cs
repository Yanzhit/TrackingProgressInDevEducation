using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TablePayments
{
    public class UpdatePaymentTerm : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdatePaymentTerm(int id, DateTime newDate)
        {
            Type = typeof(Payments);
            Name = GetType().Name;
            Params = $"{id}, {newDate}";
        }
    }
}
