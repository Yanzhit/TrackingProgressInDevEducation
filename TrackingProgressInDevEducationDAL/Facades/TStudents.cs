using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class TStudents : AFacade
    {
        public QTStudent Query { get; init; }

        /// <summary>
        /// Добавить новую Команду к студентам
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public QTStudent SetNewTStudent(int teamId, int studentId)
        {
            return (QTStudent)QuerySet.QuerySet(Query.SetNewTStudent(teamId, studentId));
        }

        /// <summary>
        /// Обнуление таблицы Команда Студенты
        /// </summary>
        /// <returns></returns>
        public IEnumerable<QTStudent> NullifyTStudent()
        {
            return (IEnumerable<QTStudent>)QuerySet.QuerySet(Query.NullifyTStudent());
        }
    }
}