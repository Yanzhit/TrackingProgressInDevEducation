using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

//ZLoo (Свойства все, Методы(SetNewCTypeБ NullifyCTypes))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице типов комментариев
    /// </summary>
    public class QCommentType : IQuery
    {
        public Type Type { get; } = typeof(CType);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создания нового типа комментария
        /// </summary>
        /// <param name="name">Название типа комментария</param>
        /// <returns></returns>
        public QCommentType SetNewCType(string name)
        {
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
            Name = nameof(NullifyCTypes);
            Params = string.Empty;
            return this;
        }
        
       
        //public QCommentType RemoveSelectedCommentType(int id)
        //{
        //    Name = nameof(RemoveSelectedCommentType);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QCommentType GetAllCommentTypes()
        //{
        //    Name = nameof(GetAllCommentTypes);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QCommentType UpdateCommentTypeById(int id, string name)
        //{
        //    Name = nameof(UpdateCommentTypeById);
        //    Params = $"{id}{Sep}{name}";
        //    return this;
        //}
    }
}