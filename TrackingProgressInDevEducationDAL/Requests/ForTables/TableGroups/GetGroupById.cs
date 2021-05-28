using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableGroups
{
   public class GetGroupById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetGroupById(int id)
        {
            Type = typeof(Groups);
            Name = GetType().Name;;
            Params = $"{id}";
        }
    }
}
