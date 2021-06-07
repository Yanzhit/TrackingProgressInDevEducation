using System.Collections.Generic;
using System.Reflection;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    public class AAnswer : ARequest
    {
        protected override void WriteTypes(ATransfer aTransfer)
        {
            Type = new[]
            {
                aTransfer.Base,
                aTransfer.Answer
            };
        }

        protected ADTOAnswer GetModelBaseSingle(AbstractModel model)
        {
            return Single(model);
        }

        protected IEnumerable<ADTOAnswer> GetModelBaseSeveral(AbstractModel model)
        {
            return Several(model);
        }

        private ADTOAnswer Single(AbstractModel model)
        {
            GetMethodSingle();
            MethodInfo generic = GetGenericSingle();
            return (ADTOAnswer)generic.Invoke(null, new object[] { model });
        }

        private IEnumerable<ADTOAnswer> Several(AbstractModel model)
        {
            GetMethodSeveral();
            MethodInfo generic = GetGenericSeveral();
            return (IEnumerable<ADTOAnswer>)generic.Invoke(null, new object[] { model });
        }
    }
}