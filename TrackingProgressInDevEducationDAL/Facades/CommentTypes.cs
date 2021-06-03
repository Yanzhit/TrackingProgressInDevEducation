using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class CommentTypes : AFacade
    {
        public QCommentType Query { get; init; }

        /// <summary>
        /// Создать новый тип комментария
        /// </summary>
        /// <param name="name">Имя типа комментария</param>
        /// <returns>Тип комментариев</returns>
        public CType SetNewCType(string name)
        {
            return (CType)Manager.Setter.Single(Query.SetNewCType(name));
        }

        /// <summary>
        /// Обнуление таблицы Типов комментариев и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CType> NullifyCTypes()
        {
            return (IEnumerable<CType>)Manager.Remove.Rem(Query.NullifyCTypes());
        }
    }
}