using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QGroup : IQuery
    {
        public Type Type { get; } = typeof(Group);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QGroup AddNewGroup(string name, int courseId)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(AddNewGroup);
            Params = $"{name}, {courseId}";
            return this;
        }
        public QGroup GetGroupById(int id)
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetGroupById);
            Params = $"{id}";
            return this;
        }
        public QGroup GetGroups()
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetGroups);
            Params = string.Empty;
            return this;
        }
        public QGroup RemoveGroupById(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveGroupById);
            Params = $"{id}";
            return this;
        }
        public QGroup UpdateGroupById(int id, string name, int courseId)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateGroupById);
            Params = $"{id}, {name}, {courseId}";
            return this;
        }
        public QGroup GetGroupsByLector(int lectorId)
        {
            TypeQueries = TypeQueries.Get;
            Name = GetType().Name;
            Params = $"{lectorId}";
            return this;
        }
        public QGroup NullifyGroups()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyGroups);
            Params = string.Empty;
            return this;
        }
    }
}