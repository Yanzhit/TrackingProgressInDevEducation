using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableLectors
{
    public class AddEmailAndPasswordLectors : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddEmailAndPasswordLectors(int id, string email, string password)
        {
            Type = typeof(Lectors);
            Name = GetType().Name;
            Params = $"{id}, {email}, {password}";
        }
    }
}
