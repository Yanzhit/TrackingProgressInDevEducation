using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QCommentFor : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; } = typeof(CommentFor);
        public string Name { get; set; }
        public string Params { get; set; }

        public QCommentFor SetNewCType()
        {
            Type = typeof(Setter);
            Name = nameof(SetNewCType);
            Params = $"";
            return this;
        }

        public QCommentFor NullifyCTypes()
        {
            Type = typeof(Remove);
            Name = nameof(NullifyCTypes);
            Params = $"";
            return this;
        }
    }
}