using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetHomeworkByid:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public GetHomeworkByid()
        {
            Type = typeof(Homeworks);
            Name = "GetHomeworkByid";
            Command = "";
        }
    }
}
