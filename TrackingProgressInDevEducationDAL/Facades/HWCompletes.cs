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
        /// Создать новое Завершенное ДЗ
        /// </summary>
        /// <param name="homeworkId">ID ДЗ</param>
        /// <param name="studentId">ID Студента</param>
        /// <param name="status">Статус Завершения ДЗ</param>
        /// <returns>Завершенное ДЗ</returns>
        public HWComplete SetNewHWComplete(int homeworkId, int studentId, bool status)
        {
            return (HWComplete)_query.QuerySet(_qHomeworkComplete.SetNewHWComplete(homeworkId, studentId, status));
        }

        /// <summary>
        /// Обнуление таблицы Завершенного ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HWComplete> NullifyHWComplete()
        {
            return (IEnumerable<HWComplete>)_query.QuerySet(_qHomeworkComplete.NullifyHWComplete());
        }
    }
}