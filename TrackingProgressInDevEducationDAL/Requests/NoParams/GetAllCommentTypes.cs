using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class GetAllCommentTypes : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetAllCommentTypes()
        {
            Type = typeof(CommentType);
            Name = "GetAllCommentTypes";
            Params = "";
        }
    }
}
