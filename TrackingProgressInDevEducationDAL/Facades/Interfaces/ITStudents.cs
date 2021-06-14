using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ITStudents
    {
        TStudent SetNewTStudent(TStudent tStudent);
        IEnumerable<TStudent> NullifyTStudent();
    }
}