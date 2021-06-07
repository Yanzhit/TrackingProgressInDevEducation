using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class SignIn : ATransfer
    {
        public SignIn GetLectorByLoginAndPassword()
        {
            Query  = typeof(QGetLector);
            Base  = typeof(Lector);
            Answer  = typeof(AGetLector);
            return this;
        }
    }
}