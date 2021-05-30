using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QComment: IQuery
    {
        public Type Type { get; } = typeof(Comment);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QComment GetComments()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetComments);
            Params = string.Empty;
            return this;
        }
        public QComment GetByIdComment(int id)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = nameof(GetByIdComment);
            Params = $"{id}";
            return this;
        }
        public QComment AddNewComment(string text, int typeId, int studentId, int createdBy)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewComment);
            Params = $"{text}, {typeId}, {studentId}, {createdBy}";
            return this;
        }
        public QComment RemoveCommentById(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemoveCommentById);
            Params = $"{id}";
            return this;
        }
        public QComment UpdateCommentById(int id, string text)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateCommentById);
            Params = $"{id}, {text}";
            return this;
        }
        public QComment NullifyComments()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyComments);
            Params = string.Empty;
            return this;
        }
    }
}