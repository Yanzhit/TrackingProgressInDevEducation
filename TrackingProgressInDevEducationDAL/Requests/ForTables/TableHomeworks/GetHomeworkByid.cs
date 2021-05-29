using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableHomeworks
{
    public class GetHomeworkById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetHomeworkById(int id)
        {
            Type = typeof(Homeworks);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
