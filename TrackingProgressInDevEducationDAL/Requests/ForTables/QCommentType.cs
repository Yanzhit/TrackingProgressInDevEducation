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
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewCommentType);
            Params = $"{name}";
            return this;
        }
        public QCommentType RemoveSelectedCommentType(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemoveSelectedCommentType);
            Params = $"{id}";
            return this;
        }
        public QCommentType GetAllCommentTypes()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetAllCommentTypes);
            Params = string.Empty;
            return this;
        }
        public QCommentType UpdateCommentTypeById(int id, string name)
        {
            TypeQueries = TypeQueries.UpdateOne;
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