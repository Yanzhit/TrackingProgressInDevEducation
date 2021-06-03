﻿using System.Collections.Generic;
 using TrackingProgressInDevEducationDAL.Abstracts;
 using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWCompletes : AFacade
    {
        public QHWComplete Query { get; init; }

        /// <summary>
        /// Создать новое Завершенное ДЗ
        /// </summary>
        /// <param name="homeworkId">ID ДЗ</param>
        /// <param name="studentId">ID Студента</param>
        /// <param name="status">Статус Завершения ДЗ</param>
        /// <returns>Завершенное ДЗ</returns>
        public HWComplete SetNewHWComplete(int homeworkId, int studentId, bool status)
        {
            return (HWComplete)Manager.Setter.Single(Query.SetNewHWComplete(homeworkId, studentId, status));
        }

        /// <summary>
        /// Обнуление таблицы Завершенного ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HWComplete> NullifyHWComplete()
        {
            return (IEnumerable<HWComplete>)Manager.Remove.Rem(Query.NullifyHWComplete());
        }
    }
}