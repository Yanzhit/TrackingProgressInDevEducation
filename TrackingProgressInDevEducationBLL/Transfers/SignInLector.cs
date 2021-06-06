using System;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class SignInLector : ITransfer
    {
        public Type Query { get; set; } = typeof(LectorQuery);
        public Type Base { get; set; } = typeof(Lector);
        public Type Answer { get; set; } = typeof(LectorAnswer);
    }
}