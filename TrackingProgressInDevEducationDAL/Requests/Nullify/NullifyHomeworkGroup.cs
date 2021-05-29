using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyHomeworkGroup : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyHomeworkGroup()
        {
            Type = typeof(HomeworkGroup);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}