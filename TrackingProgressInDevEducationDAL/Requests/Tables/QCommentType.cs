using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

//ZLoo (Свойства все, Методы(SetNewCTypeБ NullifyCTypes))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице типов комментариев
    /// </summary>
    public class QCommentType : IQuery
    {
        public Type Type { get; } = typeof(CommentType);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создания нового типа комментария
        /// </summary>
        /// <param name="name">Название типа комментария</param>
        /// <returns></returns>
        public QCommentType SetNewCType(string name)
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewCType);
            Params = $"{name}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы типов комментариев и ключа identity
        /// </summary>
        /// <returns></returns>
        public QCommentType NullifyCTypes()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyCTypes);
            Params = string.Empty;
            return this;
        }
        
       
        //public QCommentType RemoveSelectedCommentType(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveSelectedCommentType);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QCommentType GetAllCommentTypes()
        //{
        //    TypeQueries = TypeQueries.GetSeveral;
        //    Name = nameof(GetAllCommentTypes);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QCommentType UpdateCommentTypeById(int id, string name)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateCommentTypeById);
        //    Params = $"{id}{Sep}{name}";
        //    return this;
        //}
    }
}