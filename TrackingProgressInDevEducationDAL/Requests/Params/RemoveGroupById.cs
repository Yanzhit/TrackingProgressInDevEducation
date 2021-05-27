using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class RemoveGroupById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public RemoveGroupById(int id)
        {
            Type = typeof(Groups);
            Name = "RemoveGroupById";
            Params = $"{id}";
        }
    }
}
