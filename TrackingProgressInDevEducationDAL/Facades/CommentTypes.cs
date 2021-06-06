using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class CommentTypes : AFacade
    {
        private readonly QCommentType _query  = new();

        /// <summary>
        /// Создать новый тип комментария
        /// </summary>
        /// <param name="cType">Объект данных</param>
        /// <returns>Тип комментариев</returns>
        public CType SetNewCType(CType cType)
        {
            return (CType)Manager.Setter.Single(_query.SetNewCType(cType));
        }

        /// <summary>
        /// Обнуление таблицы Типов комментариев и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyCTypes()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyCTypes());
        }
    }
}