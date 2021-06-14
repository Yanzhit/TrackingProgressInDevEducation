using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IVisits
    {
        Visit SetNewVisit(Visit visit);
        IEnumerable<Visit> GetVisitsScore();
        IEnumerable<Visit> NullifyVisits();
    }
}