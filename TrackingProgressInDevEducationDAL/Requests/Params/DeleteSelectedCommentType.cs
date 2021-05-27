using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class DeleteSelectedCommentType : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public DeleteSelectedCommentType(int id)
        {
            Type = typeof(CommentType);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
