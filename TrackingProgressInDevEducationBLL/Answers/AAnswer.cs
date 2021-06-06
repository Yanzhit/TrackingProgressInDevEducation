using System;
using System.Collections.Generic;
using System.Reflection;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Answers
{
    public class AAnswer
    {
        protected readonly Mappers Mappers = new();
        protected readonly DALManager Manager = new();
        private Type[] _type;
        private MethodInfo _methodSingle;
        private MethodInfo _methodSeveral;


        protected void WriteTypes(ITransfer transfer)
        {
            _type = new[]
            {
                transfer.Base,
                transfer.Answer
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

        private MethodInfo GetGenericSingle()
        {
            return _methodSingle.MakeGenericMethod(_type);
        }
        private MethodInfo GetGenericSeveral()
        {
            return _methodSeveral.MakeGenericMethod(_type);
        }

        private void GetMethodSingle()
        {
            _methodSingle =  typeof(Mappers).GetMethod(nameof(Mappers.SingleMapping));
        }

        private void GetMethodSeveral()
        {
            _methodSeveral = typeof(Mappers).GetMethod(nameof(Mappers.SeveralMapping));
        }
    }
}