using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Requests;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public abstract class ASender
    {
        private string _command;
        private object _instatns;
        private MethodInfo _generic;

        protected AbstractModel ReflectionSingle(IQuery query, IDbConnection dbConnection, MethodInfo method)
        {
            Preparing(query, method);
            return (AbstractModel)_generic.Invoke(_instatns, new object[] {dbConnection, _command});
        }

        protected IEnumerable<AbstractModel> ReflectionSeveral(IQuery query, IDbConnection dbConnection, MethodInfo method)
        {
            Preparing(query, method);
            return (IEnumerable<AbstractModel>)_generic.Invoke(_instatns, new object[] {dbConnection, _command});
        }

        private void Preparing(IQuery query, MethodInfo method)
        {
            GetCommand(query);
            Type type = GetType(query.QueryType);
            _instatns = GetInstansClass(type);
            _generic = method.MakeGenericMethod(query.ModelType);
        }
        private object GetInstansClass(Type type)
        {
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            return constructor.Invoke(new object[]{});
        }

        private Type GetType(Type type)
        {
            if (type.FullName == typeof(Models.Results.Setter).FullName)
            {
                return typeof(Repositories.Setter);
            }
            if (type.FullName == typeof(Models.Results.Update).FullName)
            {
                return typeof(Repositories.Update);
            }
            if(type.FullName == typeof(Models.Results.Remove).FullName)
            {
                return typeof(Repositories.Remove);
            }
            return typeof(Repositories.Getter);
        }

        private void GetCommand(IQuery query)
        {
            _command = $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }
    }
}