using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateGroupById:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public UpdateGroupById()
        {
            Type = typeof(Groups);
            Name = "UpdateGroupById";
            Command = "";
        }
    }
}
