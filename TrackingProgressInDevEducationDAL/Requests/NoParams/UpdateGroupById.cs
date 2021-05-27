using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateGroupById:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateGroupById(int id,string Name, int CourseId)
        {
            Type = typeof(Groups);
            Name = "UpdateGroupById";
            Params = $"{id},{Name},{CourseId}";
        }
    }
}
