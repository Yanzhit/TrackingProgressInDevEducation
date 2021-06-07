using System;
using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class Registrations : ATransfer
    {
        public Registrations SetNewLector()
        {
            Query = typeof(QSetLector);
            Base = typeof(Lector);
            Answer = typeof(ASetLector);
            return this;
        }
    }
}