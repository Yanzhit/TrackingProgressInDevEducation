using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableCommentType
{
    public class UpdateCommentTypeById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateCommentTypeById(int id, string name)
        {
            Type = typeof(CommentType);
            Name = GetType().Name;
            Params = $"{id}, {name}";
        }
    }
}
