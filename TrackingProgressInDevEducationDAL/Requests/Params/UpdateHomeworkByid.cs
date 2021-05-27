using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateHomeworkById(string name, int id)
        {
            Type = typeof(Homeworks);
            Name = "UpdateHomeworkById";
            Params = $"{name}, {id}";
        }
    }
}
