using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
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
        /// <param name="text">Текст комментария</param>
        /// <param name="typeId">id типа комментария</param>
        /// <param name="studentId">id студента на которого написан комментарий</param>
        /// <param name="createdBy">id создателя комментария</param>
        /// <param name="teamId">id командного комментария</param>
        /// <returns>Подготовленный запрос</returns>
        public QComment SetNewComment
        (
            string text,
            int typeId,
            int? studentId,
            int createdBy,
            int? teamId
        )
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewComment);
            Params = $"{SepStr}{text}{SepMid}{typeId}{SepMid}{studentId}{SepMid}{createdBy}{SepMid}{teamId}{SepEnd}";
            return this;
        }

        public QComment SetNewCommentToStudent()
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewCommentToStudent);
            Params = $"";
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

        public QComment GetCommentsByStudent()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetCommentsByStudent);
            Params = $"";
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