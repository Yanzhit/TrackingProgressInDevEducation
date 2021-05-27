using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class GetByIdComment : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }
        public GetByIdComment(int id)
        {
            Type = typeof(Comments);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}

