using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableVisits
{
  public class GetVisitById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetVisitById(int id)
        {
            Type = typeof(Visits);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
