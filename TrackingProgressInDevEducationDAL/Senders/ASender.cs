using System;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public abstract class ASender
    {
        private string _command;

        protected object Reflection(IQuery query, IDbConnection dbConnection, MethodInfo method)
        {
            GetCommand(query);
            Type type = GetType(query);
            object instatns = GetInstansClass(type);
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            object obj = generic.Invoke(instatns, new object[] {dbConnection, _command});
            return obj;
        }

        private object GetInstansClass(Type type)
        {
            ConstructorInfo magicConstructor = type.GetConstructor(Type.EmptyTypes);
            return magicConstructor.Invoke(new object[]{});
        }

        private Type GetType(IQuery query)
        {
            if (query.Type.FullName == typeof(Models.Results.Setter).FullName)
            {
                return typeof(Repositories.Setter);
            }
            if (query.Type.FullName == typeof(Models.Results.Update).FullName)
            {
                return typeof(Repositories.Update);
            }
            if(query.Type.FullName == typeof(Models.Results.Remove).FullName)
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