using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkByid:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public UpdateHomeworkByid()
        {
            Type = typeof(Homeworks);
            Name = "UpdateHomeworkByid";
            Command = "";
        }
    }
}
