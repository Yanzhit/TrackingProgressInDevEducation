using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class CommentTypes
    {
        private readonly QCommentType _qCommentType = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать новый тип комментария
        /// </summary>
        /// <param name="name">Имя типа</param>
        /// <returns>Тип комментариев</returns>
        public CommentType SetNewCType(string name)
        {
            return (CommentType)_query.QuerySet(_qCommentType.SetNewCType(name));
        }

        /// <summary>
        /// Обнуление таблицы Типов комментариев и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CommentType> NullifyCTypes()
        {
            return (IEnumerable<CommentType>)_query.QuerySet(_qCommentType.NullifyCTypes());
        }
    }
}