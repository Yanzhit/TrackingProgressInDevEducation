using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(NullifyComments)(В SetNewComment нужно до настроить входящие параметры (null)))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице комментариев
    /// </summary>
    public class QComment: IQuery
    {
        public Type Type { get; } = typeof(Comment);
        public TypeQueries TypeQueries { get; set; }
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
            int studentId,
            int createdBy,
            int teamId
        )
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewComment);
            Params = $"{text}{Sep}{typeId}{Sep}{studentId}{Sep}{createdBy}{Sep}{teamId}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QComment NullifyComments()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyComments);
            Params = string.Empty;
            return this;
        }

        //public QComment GetComments()
        //{
        //    TypeQueries = TypeQueries.GetSeveral;
        //    Name = nameof(GetComments);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QComment GetByIdComment(int id)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetByIdComment);
        //    Params = $"{id}";
        //    return this;
        //}
        
        //public QComment RemoveCommentById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveCommentById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QComment UpdateCommentById(int id, string text)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateCommentById);
        //    Params = $"{id}{Sep}{text}";
        //    return this;
        //}
    }
}