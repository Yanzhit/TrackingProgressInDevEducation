using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Comments
    {
        private readonly QComment _qComments = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать новый курс
        /// </summary>
        /// <param name="text">Текст комментария</param>
        /// <param name="typeId">ID типа</param>
        /// <param name="studentId">ID студента</param>
        /// <param name="createdBy">ID преподователя, создавшего комментарий</param>
        /// <param name="teamId">ID комманды</param>
        /// <returns>Комментарий</returns>
        public Comment SetNewComment
        (
            string text,
            int typeId,
            int studentId,
            int createdBy,
            int teamId
        )
        {
            return (Comment) _query.QuerySet
            (
                _qComments.SetNewComment
                (
                    text,
                    typeId,
                    studentId,
                    createdBy,
                    teamId
                )
            );
        }


        /// <summary>
        /// Обнуление таблицы Комментариев и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Comment> NullifyComments()
        {
            return (List<Comment>)_query.QuerySet(_qComments.NullifyComments());
        }
    }
}