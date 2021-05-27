using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class RemoveHomeworksByid:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public RemoveHomeworksByid(int id)
        {
            Type = typeof(Homeworks);
            Name = "RemoveHomeworksByid";
            Params = $"{id}";
        }
    }
}
