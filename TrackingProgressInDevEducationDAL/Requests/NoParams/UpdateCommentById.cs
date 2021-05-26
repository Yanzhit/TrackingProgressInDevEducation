using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateCommentById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public UpdateCommentById()
        {
            Type = typeof(Students);
            Name = "UpdateCommentById";
            Command = "";
        }
    }
}
