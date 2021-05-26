using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class RemoveCommentById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public RemoveCommentById()
        {
            Type = typeof(Comments);
            Name = "RemoveCommentById";
            Command = "";
        }
    }
}
