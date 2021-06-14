using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ILectors
    {
        Lector GetLectorByLoginAndPassword(Lector model);
        Lector SetNewLector(Lector model);
        Lector UpdateAcrivationLector(Lector lector);



    }
}