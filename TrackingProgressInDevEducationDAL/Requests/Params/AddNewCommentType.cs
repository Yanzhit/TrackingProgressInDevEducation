using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class AddNewCommentType : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewCommentType(string name)
        {
            Type = typeof(CommentType);
            Name = GetType().Name;
            Params = $"{name}";
        }
    }
}
