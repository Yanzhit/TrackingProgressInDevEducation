using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableVisits
{
   public class UpdateVisitById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateVisitById(int id, bool visitStatus, int studentId, int lectionId)
        {
            Type = typeof(Visits);
            Name = GetType().Name;
            Params = $"{id}, {visitStatus}, {studentId}, {lectionId}";
        }
    }
}
