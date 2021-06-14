using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IHomeworks
    {
        Homework SetNewHW(Homework homework);
        IEnumerable<Homework> NullifyHWs();
    }
}