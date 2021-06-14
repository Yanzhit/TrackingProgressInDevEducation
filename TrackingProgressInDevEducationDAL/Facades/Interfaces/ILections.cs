using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ILections
    {
        Lection SetNewLection(Lection lection);
        //IEnumerable<Lection> GetAllLector();
        IEnumerable<Lection> NullifyLections();
    }
}