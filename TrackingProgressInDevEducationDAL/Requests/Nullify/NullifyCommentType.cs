using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Nullify
{
    public class NullifyCommentType : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public NullifyCommentType()
        {
            Type = typeof(NullifyCommentType);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}