﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Models.Bases;
 using TrackingProgressInDevEducationDAL.Models.Results;
 using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWCompletes : AFacade
    {
        private readonly QHWComplete _query  = new();

        /// <summary>
        /// Создать новое Завершенное ДЗ
        /// </summary>
        /// <param name="homeworkId">ID ДЗ</param>
        /// <param name="studentId">ID Студента</param>
        /// <param name="status">Статус Завершения ДЗ</param>
        /// <returns>Завершенное ДЗ</returns>
        public AResult SetNewHWComplete(int homeworkId, int studentId, bool status)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewHWComplete(homeworkId, studentId, status));
        }

        public IEnumerable<HWComplete> GetHomeWorkProcedureScore()
        {
            return (IEnumerable<HWComplete>)Manager.Getter.Several(_query.GetHomeWorkProcedureScore());
        }

        /// <summary>
        /// Обнуление таблицы Завершенного ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyHWComplete()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyHWComplete());
        }
    }
}