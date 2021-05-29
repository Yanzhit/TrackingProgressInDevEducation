using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QCommentType : IQuery
    {
        public Type Type { get; } = typeof(CommentType);
        public string Name { get; set; }
        public string Params { get; set; }

        public QCommentType AddNewCommentType(string name)
        {
            Name = nameof(AddNewCommentType);
            Params = $"{name}";
            return this;
        }

        public QCommentType DeleteSelectedCommentType(int id)
        {
            Name = nameof(DeleteSelectedCommentType);
            Params = $"{id}";
            return this;
        }

        public QCommentType GetAllCommentTypes()
        {
            Name = nameof(GetAllCommentTypes);
            Params = string.Empty;
            return this;
        }

        public QCommentType UpdateCommentTypeById(int id, string name)
        {
            Name = nameof(UpdateCommentTypeById);
            Params = $"{id}, {name}";
            return this;
        }

        public QCommentType NullifyCommentType()
        {
            Name = nameof(NullifyCommentType);
            Params = string.Empty;
            return this;
        }
    }
}