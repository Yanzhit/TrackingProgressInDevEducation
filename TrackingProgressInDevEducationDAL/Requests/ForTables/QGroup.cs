using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

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
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewGroup);
            Params = $"{name}{Sep}{courseId}";
            return this;
        }
        public QGroup GetGroupById(int id)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = nameof(GetGroupById);
            Params = $"{id}";
            return this;
        }
        public QGroup GetGroups()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetGroups);
            Params = string.Empty;
            return this;
        }
        public QGroup RemoveGroupById(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemoveGroupById);
            Params = $"{id}";
            return this;
        }
        public QGroup UpdateGroupById(int id, string name, int courseId)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateGroupById);
            Params = $"{id}{Sep}{name}{Sep}{courseId}";
            return this;
        }
        public QGroup GetGroupsByLector(int lectorId)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = GetType().Name;
            Params = $"{lectorId}";
            return this;
        }
        public QGroup NullifyGroups()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyGroups);
            Params = string.Empty;
            return this;
        }
    }
}