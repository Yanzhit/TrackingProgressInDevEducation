using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableGroups
{
    public class AddNewGroup : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewGroup(string name, int courseId)
        {
            Type = typeof(Groups);
            Name = GetType().Name;
            Params = $"{name}, {courseId}";
        }
    }
}
