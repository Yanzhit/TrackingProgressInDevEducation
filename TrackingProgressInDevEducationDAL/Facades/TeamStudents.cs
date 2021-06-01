using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Abstarcts;
﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class TeamStudents : AFacade
    {
        public QTeamStudent Query { get; set; }

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