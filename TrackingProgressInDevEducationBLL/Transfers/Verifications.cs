using TrackingProgressInDevEducationBLL.Models.Verification;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Verifications : ATransfer
    {
        public Verifications UpdateActivationLector()
        {
            Query = typeof(UpdLectorQ);
            Base = typeof(Lector);
            Answer = typeof(UpdLectorA);
            return this;
        }
    }
}