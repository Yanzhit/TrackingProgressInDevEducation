using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class AddNewGroup : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewGroup(string name, int courseId)
        {
            Type = typeof(Groups);
            Name = "AddNewGroup";
            Params = $"{name}, {courseId}";
        }
    }
}
