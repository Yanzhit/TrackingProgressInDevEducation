using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class RegistrationsQ : AQuery
    {
        public AbstractModel SetNewLector(SetLectorQ model)
        {
            WriteTypes(new Registrations().SetNewLector());
            return GetModelBaseSingle(model);
        }
    }
}