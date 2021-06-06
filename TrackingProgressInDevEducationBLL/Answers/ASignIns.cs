using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Answers
{
    public class ASignIns : AAnswer
    {
        public LectorAnswer GetLoginAndPassword(Lector model)
        {
            WriteTypes(new SignInLector());
            return (LectorAnswer)GetModelBaseSingle(model);
        }
    }
}