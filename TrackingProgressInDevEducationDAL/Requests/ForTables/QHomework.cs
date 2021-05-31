using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomework : IQuery
    {
        public Type Type { get; } = typeof(Homework);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomework SetNewHWs(string name)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(SetNewHWs);
            Params = $"{name}";
            return this;
        }
        public QHomework GetHomeworkById(int id)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = nameof(GetHomeworkById);
            Params = $"{id}";
            return this;
        }
        public QHomework RemoveHomeworksById(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemoveHomeworksById);
            Params = $"{id}";
            return this;
        }
        public QHomework UpdateHomeworkById(string name, int id)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateHomeworkById);
            Params = $"{name}{Sep}{id}";
            return this;
        }
        public QHomework NullifyHomeworks()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyHomeworks);
            Params = string.Empty;
            return this;
        }
    }
}