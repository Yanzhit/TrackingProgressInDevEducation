using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
  public class AddNewVisit : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            Type = typeof(Visits);
            Name = GetType().Name;
            Params = $"{visitStatus}, {studentId}, {lectionId}";
        }
    }
}
