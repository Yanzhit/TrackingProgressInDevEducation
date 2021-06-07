using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class QRegistrations : AQuery
    {
        public AbstractModel SetNewLector(QNewLector qNewLector)
        {
            WriteTypes(new RegistrationNewLector());
            return GetModelBaseSingle(qNewLector);
        }
    }
}