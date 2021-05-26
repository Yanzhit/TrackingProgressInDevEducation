using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
   public class RemoveComments : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public RemoveComments()
        {
            Type = typeof(Comments);
            Name = "RemoveComments";
            Command = "";
        }
    }
}
