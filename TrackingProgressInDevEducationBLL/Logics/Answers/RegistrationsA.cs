using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class RegistrationsA : AAnswer
    {
        public SetLectorA SetNewLector(AbstractModel model)
        {
            WriteTypes(new Registrations().SetNewLector());
            return (SetLectorA)GetModelBaseSingle(model);
        }
    }
}