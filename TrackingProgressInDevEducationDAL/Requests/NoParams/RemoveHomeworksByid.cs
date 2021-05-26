using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class RemoveHomeworksByid
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public RemoveHomeworksByid()
        {
            Type = typeof(Homeworks);
            Name = "RemoveHomeworksByid";
            Command = "";
        }
    }
}
