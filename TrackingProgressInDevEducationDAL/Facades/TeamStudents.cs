using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class TeamStudents
    {
        private readonly QTeamStudent _qTeamStudent = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Добавить новую Команду к студентам
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Команда к Студентам</returns>
        public QTeamStudent SetNewTStudent(int teamId, int studentId)
        {
            return (QTeamStudent)_query.QuerySet(_qTeamStudent.SetNewTStudent(teamId, studentId));
        }

        /// <summary>
        /// Обнуление таблицы Команда Студенты
        /// </summary>
        /// <returns></returns>
        public IEnumerable<QTeamStudent> NullifyTStudent()
        {
            return (IEnumerable<QTeamStudent>)_query.QuerySet(_qTeamStudent.NullifyTStudent());
        }
    }
}