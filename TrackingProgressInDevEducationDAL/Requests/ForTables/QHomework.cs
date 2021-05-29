using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomework : IQuery
    {
        public Type Type { get; } = typeof(Homework);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomework CreateNewHomeworks(string name)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(CreateNewHomeworks);
            Params = $"{name}";
            return this;
        }
        public QHomework GetHomeworkById(int id)
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetHomeworkById);
            Params = $"{id}";
            return this;
        }
        public QHomework RemoveHomeworksById(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveHomeworksById);
            Params = $"{id}";
            return this;
        }
        public QHomework UpdateHomeworkById(string name, int id)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateHomeworkById);
            Params = $"{name}, {id}";
            return this;
        }
        public QHomework NullifyHomeworks()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyHomeworks);
            Params = string.Empty;
            return this;
        }
    }
}