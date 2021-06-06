using System;
using System.ComponentModel;
using System.Reflection;
using AutoMapper.Internal;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Requests
{
    public abstract class AQuery
    {
        protected readonly Mappers Mappers = new();
        protected readonly DALManager Manager = new();

        protected ADTOAnswer Single(AbstractModel model, ITransfer transfer)
        {
            Type[] type = WriteTypes(transfer);
            MethodInfo method = typeof(Mappers).GetMethod(nameof(Mappers.SingleMapping));
            MethodInfo generic = method.MakeGenericMethod(type);
            return (ADTOAnswer)generic.Invoke(null, new object[] { model });
        }

        //protected ADTO Several(AbstractModel model, ITransfer transfer)
        //{
        //    Type[] type = WriteTypes(transfer);
        //    MethodInfo method = typeof(Mappers).GetMethod(nameof(Mappers.SeveralMapping));
        //    MethodInfo generic = method.MakeGenericMethod(type);
        //    return (ADTO)generic.Invoke(null, new object[] { model });
        //}

        private Type[] WriteTypes(ITransfer transfer)
        {
            return new[]
            {
                transfer.Base,
                transfer.Answer
            };
        }
    }
}