using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Requests.ForTables;
﻿using TrackingProgressInDevEducationDAL.Requests.Tables;
using TrackingProgressInDevEducationDAL.Abstarcts;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWGroups : AFacade 
    {
        public QHWGroup Query { get; set; }

        /// <summary>
        /// Создать новое ДЗ ГРУППЫ
        /// </summary>
        /// <param name="homeworkId">ID ДЗ</param>
        /// <param name="groupId">ID Группы</param>
        /// <returns>ДЗ ГРУППЫ</returns>
        public QHomeworkGroup SetNewHWGroup(int homeworkId, int groupId)
        {
            return (QHomeworkGroup)_query.QuerySet(_qHomeworkGroup.SetNewHWGroup(homeworkId, groupId));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ ГРУППЫ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<QHomeworkGroup> NullifyHWGroup()
        {
            return (IEnumerable<QHomeworkGroup>)_query.QuerySet(_qHomeworkGroup.NullifyHWGroup());
        }
    }
}