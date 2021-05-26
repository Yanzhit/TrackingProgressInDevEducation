using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class RemoveGroupById:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public RemoveGroupById()
        {
            Type = typeof(Groups);
            Name = "RemoveGroupById";
            Command = "";
        }
    }
}
