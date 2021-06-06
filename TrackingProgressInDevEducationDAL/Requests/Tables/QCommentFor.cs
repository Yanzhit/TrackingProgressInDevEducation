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

        public QCommentFor SetNewCType()
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewCType);
            Params = $"";
            return this;
        }

        public QCommentFor NullifyCTypes()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyCTypes);
            Params = $"";
            return this;
        }
    }
}