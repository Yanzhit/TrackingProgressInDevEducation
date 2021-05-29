using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Others
{
   public class GetGroupsByLector : IQuery
    {
        public Type Type { get; }
        public string Name { get; set; }
        public string Params { get; set; }

        public GetGroupsByLector(int lectorId)
        {
            Type = typeof(Group);
            Name = GetType().Name;
            Params = $"{lectorId}";
        }
    }
}
