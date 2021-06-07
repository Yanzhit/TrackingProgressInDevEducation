using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class ARegistrations : AAnswer
    {
        public ASetLector SetNewLector(AbstractModel model)
        {
            WriteTypes(new Registrations().SetNewLector());
            return (ASetLector)GetModelBaseSingle(model);
        }
    }
}