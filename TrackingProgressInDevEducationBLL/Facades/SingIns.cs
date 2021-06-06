using System;
using System.Reflection;
using TrackingProgressInDevEducationBLL.Models.SignIn;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Facades
{
    public class SingIns : AFacade
    {
        public LectorAnswer GetLoginAndPassword(string email, string password)
        {
            var lectorF = new LectorQuery(email, password);
            MethodInfo method = typeof(Mappers).GetMethod(nameof(Mappers.SingleMapping));
            SignInLector lector = new SignInLector();
            //Type[] type = new[]
            //{
            //    //lector.First,
            //    //lector.Middle
            //};
        //    MethodInfo generic = method.MakeGenericMethod(type);
         //   var lectorM = generic.Invoke(null, new object[] { lectorF });

         //   Manager.Lectors.GetLoginAndPassword((Lector)lectorM);




            return new LectorAnswer();
        }
    }
}