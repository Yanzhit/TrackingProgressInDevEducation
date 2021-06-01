using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWCompletes
    {
        private readonly QHomeworkComplete _qHomeworkComplete = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать новое ДЗ
        /// </summary>
        /// <param name="name">Имя ДЗ</param>
        /// <returns>ДЗ</returns>
        public HWComplete SetNewHW(int homeworkId, int studentId, bool status)
        {
            return (HWComplete)_query.QuerySet(_qHomeworkComplete.SetNewHWComplete(homeworkId, studentId, status));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HWComplete> NullifyHWs()
        {
            return (IEnumerable<HWComplete>)_query.QuerySet(_qHomeworkComplete.NullifyHWComplete());
        }
    }
}