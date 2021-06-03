using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Comments : AFacade
    {
        public QComment Query { get; init; }

        /// <summary>
        /// Создать новый курс
        /// </summary>
        /// <param name="text">Текст комментария</param>
        /// <param name="typeId">ID типа</param>
        /// <param name="studentId">ID студента</param>
        /// <param name="createdBy">ID преподавателя, создавшего комментарий</param>
        /// <param name="teamId">ID команды</param>
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
            return (Comment) Manager.Setter.Single
            (
                Query.SetNewComment
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
            return (List<Comment>)Manager.Remove.Rem(Query.NullifyComments());
        }
    }
}