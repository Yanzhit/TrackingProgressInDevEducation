using System;
using TrackingProgressInDevEducationBLL.Models.Registration;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class RegistrationNewLector : ITransfer
    {
        public Type Query { get; set; } = typeof(QNewLector);
        public Type Base { get; set; } = typeof(Lector);
        public Type Answer { get; set; } = typeof(ANewLector);
    }
}