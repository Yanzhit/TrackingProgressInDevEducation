using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableStudents
{
    public class GetStudents : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetStudents()
        {
            Type = typeof(Models.Bases.Students);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}