using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyPayments : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyPayments()
        {
            Type = typeof(NullifyPayments);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}