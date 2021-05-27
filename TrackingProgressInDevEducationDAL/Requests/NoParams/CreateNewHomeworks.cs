using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class CreateNewHomeworks:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public CreateNewHomeworks(string Name)
        {
            Type = typeof(Homeworks);
            Name = "CreateNewHomeworks";
            Params = $"{Name}";
        }
    }
}
