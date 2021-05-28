using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public  class GetComments : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetComments()
        {
            Type = typeof(Comments);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}
