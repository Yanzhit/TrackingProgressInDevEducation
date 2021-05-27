using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class RemoveHomeworksById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public RemoveHomeworksById(int id)
        {
            Type = typeof(Homeworks);
            Name = "RemoveHomeworksById";
            Params = $"{id}";
        }
    }
}
