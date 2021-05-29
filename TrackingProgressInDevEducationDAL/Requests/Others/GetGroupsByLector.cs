using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Others
{
   public class GetGroupsByLector:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetGroupsByLector(int lectorId)
        {
            Type = typeof(Groups);
            Name = GetType().Name;
            Params = $"{lectorId}";
        }
    }
}
