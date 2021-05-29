using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QGroup : IQuery
    {
        public Type Type { get; } = typeof(Group);
        public string Name { get; set; }
        public string Params { get; set; }

        public QGroup AddNewGroup(string name, int courseId)
        {
            Name = nameof(AddNewGroup);
            Params = $"{name}, {courseId}";
            return this;
        }
        public QGroup GetGroupById(int id)
        {
            Name = nameof(GetGroupById);
            Params = $"{id}";
            return this;
        }
        public QGroup GetGroups()
        {
            Name = nameof(GetGroups);
            Params = string.Empty;
            return this;
        }
        public QGroup RemoveGroupById(int id)
        {
            Name = nameof(RemoveGroupById);
            Params = $"{id}";
            return this;
        }
        public QGroup UpdateGroupById(int id, string name, int courseId)
        {
            Name = nameof(UpdateGroupById);
            Params = $"{id}, {name}, {courseId}";
            return this;
        }
        public QGroup NullifyGroups()
        {
            Name = nameof(NullifyGroups);
            Params = string.Empty;
            return this;
        }
    }
}