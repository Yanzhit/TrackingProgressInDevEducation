using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QComment: IQuery
    {
        public Type Type { get; } = typeof(Comment);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QComment GetComments()
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetComments);
            Params = string.Empty;
            return this;
        }
        public QComment GetByIdComment(int id)
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetByIdComment);
            Params = $"{id}";
            return this;
        }
        public QComment AddNewComment(string text, int typeId, int studentId, int createdBy)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(AddNewComment);
            Params = $"{text}, {typeId}, {studentId}, {createdBy}";
            return this;
        }
        public QComment RemoveCommentById(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveCommentById);
            Params = $"{id}";
            return this;
        }
        public QComment UpdateCommentById(int id, string text)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateCommentById);
            Params = $"{id}, {text}";
            return this;
        }
        public QComment NullifyComments()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyComments);
            Params = string.Empty;
            return this;
        }
    }
}