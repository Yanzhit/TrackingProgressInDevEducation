using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QCommentFor : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(CommentFor);
        public string Name { get; set; }
        public string Params { get; set; }

        public QCommentFor SetNewCFor()
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewCFor);
            Params = $"";
            return this;
        }

        public QCommentFor NullifyCFor()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyCFor);
            Params = $"";
            return this;
        }
    }
}