using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWGroups : AFacade 
    {
        public QHWGroup Query { get; init; }

        /// <summary>
        /// Создать новое ДЗ ГРУППЫ
        /// </summary>
        /// <param name="homeworkId">ID ДЗ</param>
        /// <param name="groupId">ID Группы</param>
        /// <returns>ДЗ ГРУППЫ</returns>
        public QHWGroup SetNewHWGroup(int homeworkId, int groupId)
        {
            return (QHWGroup)Manager.Setter.Single(Query.SetNewHWGroup(homeworkId, groupId));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ ГРУППЫ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<QHWGroup> NullifyHWGroup()
        {
            return (IEnumerable<QHWGroup>)Manager.Nullify.Null(Query.NullifyHWGroup());
        }
    }
}