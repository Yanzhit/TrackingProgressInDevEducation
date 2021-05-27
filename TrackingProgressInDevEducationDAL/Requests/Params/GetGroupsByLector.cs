using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
   public class GetGroupsByLector:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetGroupsByLector(int lectorId)
        {
            Type = typeof(Groups);
            Name = "GetGroupsByLector";
            Params = $"{lectorId}";
        }
    }
}
