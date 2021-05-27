using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetHomeworkByid:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetHomeworkByid(int id)
        {
            Type = typeof(Homeworks);
            Name = "GetHomeworkByid";
            Params = $"{id}";
        }
    }
}
