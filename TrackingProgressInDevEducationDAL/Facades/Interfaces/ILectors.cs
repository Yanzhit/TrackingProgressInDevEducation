using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ILectors
    {
        Lector GetLectorByLoginAndPassword(Lector model);
    }
}