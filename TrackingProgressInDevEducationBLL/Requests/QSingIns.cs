using System.Reflection;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Requests
{
    public class QSingIns : AQuery
    {
        public LectorAnswer GetLoginAndPassword(LectorQuery lectorQuery)
        {
            Lector lector = Manager.Lectors.GetLoginAndPassword(lectorQuery.Email, lectorQuery.Password);
            return (LectorAnswer)Single(lector, new SignInLector());
        }
    }
}