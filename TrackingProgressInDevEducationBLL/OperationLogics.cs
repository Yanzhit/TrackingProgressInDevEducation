using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL
{
    public class OperationLogics
    {
        private readonly DALManager _dalManager = new();
        private readonly BLLManager _bllManager = new();
        public LectorAnswer GetLoginAndPassword(LectorQuery lectorQuery)
        {
            Lector model = (Lector)_bllManager.QSignIns.GetLoginAndPassword(lectorQuery);
            Lector modelReturned = _dalManager.Lectors.GetLoginAndPassword(model);
            return _bllManager.ASignIns.GetLoginAndPassword(modelReturned);
        }
    }
}