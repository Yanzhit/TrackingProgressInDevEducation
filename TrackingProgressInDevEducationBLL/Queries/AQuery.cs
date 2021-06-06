using System;
using System.Collections.Generic;
using System.Reflection;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Queries
{
    public abstract class AQuery
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
                transfer.Query,
                transfer.Base
            };
        }

        protected AbstractModel GetModelBaseSingle(ADTOQuery adtoQuery)
        {
            return Single(adtoQuery);
        }

        protected IEnumerable<AbstractModel> GetModelBaseSeveral(ADTOQuery adtoQuery)
        {
            return Several(adtoQuery);
        }

        private AbstractModel Single(ADTOQuery model)
        {
            GetMethodSingle();
            MethodInfo generic = GetGenericSingle();
            return (AbstractModel)generic.Invoke(null, new object[] { model });
        }

        private IEnumerable<AbstractModel> Several(ADTOQuery model)
        {
            GetMethodSeveral();
            MethodInfo generic = GetGenericSeveral();
            return (IEnumerable<AbstractModel>)generic.Invoke(null, new object[] { model });
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