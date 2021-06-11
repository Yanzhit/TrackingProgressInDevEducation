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
            Types = new[]
            {
                aTransfer.Base,
                aTransfer.Answer
            };
        }

        protected ADTOAnswer GetModelBaseSingle(AbstractModel model)
        {
            return Single(model);
        }

        protected IEnumerable<ADTOAnswer> GetModelBaseSeveral(IEnumerable<AbstractModel> model)
        {
            return Several(model);
        }

        private ADTOAnswer Single(AbstractModel model)
        {
            GetMethodSingle();
            MethodInfo generic = GetGenericSingle();
            GetInstansClass();
            return (ADTOAnswer)generic.Invoke(Instants, new object[] { model });
        }

        private IEnumerable<ADTOAnswer> Several(IEnumerable<AbstractModel> model)
        {
            GetMethodSeveral();
            MethodInfo generic = GetGenericSeveral();
            GetInstansClass();
            return (IEnumerable<ADTOAnswer>)generic.Invoke(Instants, new object[] { model });
        }
    }
}