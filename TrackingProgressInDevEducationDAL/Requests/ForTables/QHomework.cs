using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomework : IQuery
    {
        public Type Type { get; } = typeof(Homework);
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomework CreateNewHomeworks(string name)
        {
            Name = nameof(CreateNewHomeworks);
            Params = $"{name}";
            return this;
        }
        public QHomework GetHomeworkById(int id)
        {
            Name = nameof(GetHomeworkById);
            Params = $"{id}";
            return this;
        }
        public QHomework RemoveHomeworksById(int id)
        {
            Name = nameof(RemoveHomeworksById);
            Params = $"{id}";
            return this;
        }
        public QHomework UpdateHomeworkById(string name, int id)
        {
            Name = nameof(UpdateHomeworkById);
            Params = $"{name}, {id}";
            return this;
        }
        public QHomework NullifyHomeworks()
        {
            Name = nameof(NullifyHomeworks);
            Params = string.Empty;
            return this;
        }
    }
}