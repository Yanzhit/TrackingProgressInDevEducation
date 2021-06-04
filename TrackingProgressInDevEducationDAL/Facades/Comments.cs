using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Comments : AFacade
    {
        private readonly QComment _query = new();

        /// <summary>
        /// Создать новый курс
        /// </summary>
        /// <param name="text">Текст комментария</param>
        /// <param name="typeId">ID типа</param>
        /// <param name="studentId">ID студента</param>
        /// <param name="createdBy">ID преподавателя, создавшего комментарий</param>
        /// <param name="teamId">ID команды</param>
        /// <returns>Комментарий</returns>
        public AResult SetNewComment
        (
            string text,
            int typeId,
            int? studentId,
            int createdBy,
            int? teamId
        )
        {
            return (AResult) Manager.Setter.Single
            (
                _query.SetNewComment
                (
                    text,
                    typeId,
                    studentId,
                    createdBy,
                    teamId
                )
            );
        }

        public AResult SetNewCommentToStudent()
        {
            return (AResult)Manager.Setter.Single(_query.SetNewCommentToStudent());
        }

        public IEnumerable<AResult> SetCommentToTeam()
        {
            return (List<AResult>)Manager.Setter.Several(_query.SetCommentToTeam());
        }

        public IEnumerable<AResult> GetCommentsByStudent()
        {
            return (List<AResult>)Manager.Getter.Several(_query.GetCommentsByStudent());
        }

        public IEnumerable<AResult> GetCommentsByTeam()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetCommentsByTeam());
        }

        /// <summary>
        /// Обнуление таблицы Комментариев и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyComments()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyComments());
        }
    }
}