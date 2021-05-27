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

        public AddNewVisit(bool VisitStatus, int StudentId, int LectionId)
        {
            Type = typeof(Visits);
            Name = "AddNewVisit";
            Params = $"{VisitStatus}, {StudentId}, {LectionId}";
        }
    }
}
