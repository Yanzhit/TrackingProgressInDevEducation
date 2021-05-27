using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class AddNewLector : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewLector(string fullName)
        {
            Type = typeof(Lectors);
            Name = GetType().Name;
            Params = $"{fullName}";
        }
    }
}
