using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Models.Facades
{
    public class Comments : AFacade
    {
        private readonly QComment _query = new();

        /// <summary>
        /// Создать новый курс
        /// </summary>
        /// <param name="comment">Объект данных</param>
        /// <returns>Комментарий</returns>
        public Comment SetNewComment(Comment comment)
        {
            return (Comment) Manager.Setter.Single
            (
                _query.SetNewComment(comment)
            );
        }

        public Comment SetNewCommentToStudent()
        {
            return (Comment)Manager.Setter.Single(_query.SetNewCommentToStudent());
        }

        public IEnumerable<Comment> SetCommentToTeam()
        {
            return (List<Comment>)Manager.Setter.Several(_query.SetCommentToTeam());
        }

        public IEnumerable<Comment> GetCommentsByStudent()
        {
            return (List<Comment>)Manager.Getter.Several(_query.GetCommentsByStudent());
        }

        public IEnumerable<Comment> GetCommentsByTeam()
        {
            return (IEnumerable<Comment>)Manager.Getter.Several(_query.GetCommentsByTeam());
        }

        /// <summary>
        /// Обнуление таблицы Комментариев и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Comment> NullifyComments()
        {
            return (IEnumerable<Comment>)Manager.Remove.Rem(_query.NullifyComments());
        }
    }
}