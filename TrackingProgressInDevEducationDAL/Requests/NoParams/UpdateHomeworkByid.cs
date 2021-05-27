using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkByid:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateHomeworkByid(string Name, int id)
        {
            Type = typeof(Homeworks);
            Name = "UpdateHomeworkByid";
            Params = $"{Name},{id}";
        }
    }
}
