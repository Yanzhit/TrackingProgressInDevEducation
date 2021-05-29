using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomeworkGroup : IQuery
    {
        public Type Type { get; } = typeof(HomeworkGroup);
        public string Name { get; set; }
        public string Params { get; set; }
    }
}