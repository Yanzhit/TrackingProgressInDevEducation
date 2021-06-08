using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class SignIns : ATransfer
    {
        public SignIns GetLectorByLoginAndPassword()
        {
            Query  = typeof(GetLectorQ);
            Base  = typeof(Lector);
            Answer  = typeof(GetLectorA);
            return this;
        }
    }
}