using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(NullifyComments)(В SetNewComment нужно до настроить входящие параметры (null)))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице комментариев
    /// </summary>
    public class QComment: IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Comment);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создания нового комментария
        /// </summary>
        /// <param name="comment">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QComment SetNewComment(Comment comment)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewComment);
            Params = $"{SepStr}{comment.Text}{SepMid}{comment.TypeId}{SepMid}" +
                     $"{comment.StudentId}{SepMid}{comment.CreatedBy}{SepMid}" +
                     $"{comment.TeamId}{SepEnd}";
            return this;
        }

        public QComment SetNewCommentToStudent(Comment comment)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewCommentToStudent);
            Params = $"{SepStr}{comment.Text}{SepMid}{comment.TypeId}{SepMid}" +
                     $"{comment.StudentId}{SepMid}{comment.CreatedBy}{SepMid}" +
                     $"{comment.Estimation}{SepEnd}";
            return this;
        }

        public QComment SetCommentToTeam()
        {
            QueryType = typeof(Setter);
            Name = nameof(SetCommentToTeam);
            Params = $"";
            return this;
        }

        public QComment GetCommentsByTeam()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetCommentsByTeam);
            Params = $"";
            return this;
        }

        public QComment GetCommentsByStudent(Comment comment)
        {
            QueryType = typeof(Getter);
            Name = nameof(GetCommentsByStudent);
            Params = $"{SepStr}{comment.Text}{SepMid}{comment.Estimation}{SepEnd}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QComment NullifyComments()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyComments);
            Params = string.Empty;
            return this;
        }

        //public QComment GetComments()
        //{
        //    Name = nameof(GetComments);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QComment GetByIdComment(int id)
        //{
        //    Name = nameof(GetByIdComment);
        //    Params = $"{id}";
        //    return this;
        //}
        
        //public QComment RemoveCommentById(int id)
        //{
        //    Name = nameof(RemoveCommentById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QComment UpdateCommentById(int id, string text)
        //{
        //    Name = nameof(UpdateCommentById);
        //    Params = $"{id}{Sep}{text}";
        //    return this;
        //}
    }
}