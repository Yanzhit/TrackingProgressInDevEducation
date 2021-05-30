using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QCommentType : IQuery
    {
        public Type Type { get; } = typeof(CommentType);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QCommentType AddNewCommentType(string name)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(AddNewCommentType);
            Params = $"{name}";
            return this;
        }
        public QCommentType RemoveSelectedCommentType(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveSelectedCommentType);
            Params = $"{id}";
            return this;
        }
        public QCommentType GetAllCommentTypes()
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetAllCommentTypes);
            Params = string.Empty;
            return this;
        }
        public QCommentType UpdateCommentTypeById(int id, string name)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateCommentTypeById);
            Params = $"{id}, {name}";
            return this;
        }
        public QCommentType NullifyCommentType()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyCommentType);
            Params = string.Empty;
            return this;
        }
    }
}