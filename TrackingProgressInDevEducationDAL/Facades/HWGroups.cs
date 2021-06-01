using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWGroups
    {
        private readonly QHomeworkGroup _qHomeworkGroup = new();
        private readonly QuerySettings _query = new();

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