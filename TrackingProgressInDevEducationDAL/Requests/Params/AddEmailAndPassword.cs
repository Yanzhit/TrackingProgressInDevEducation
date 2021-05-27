using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class AddEmailAndPassword : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddEmailAndPassword(int id, string email, string password)
        {
            Type = typeof(Lectors);
            Name = "AddEmailAndPassword";
            Params = $"{id}, {email}, {password}";
        }
    }
}
