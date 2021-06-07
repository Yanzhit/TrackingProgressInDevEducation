using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class QRegistrations : AQuery
    {
        public AbstractModel SetNewLector(QSetLector qSetLector)
        {
            WriteTypes(new Registrations().SetNewLector());
            return GetModelBaseSingle(qSetLector);
        }
    }
}