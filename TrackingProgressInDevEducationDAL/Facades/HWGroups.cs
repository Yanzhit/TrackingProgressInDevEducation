using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWGroups : AFacade 
    {
        private readonly QHWGroup _query  = new();

        /// <summary>
        /// Создать новое ДЗ ГРУППЫ
        /// </summary>
        /// <param name="homeworkId">ID ДЗ</param>
        /// <param name="groupId">ID Группы</param>
        /// <returns>ДЗ ГРУППЫ</returns>
        public AResult SetNewHWGroup(int homeworkId, int groupId)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewHWGroup(homeworkId, groupId));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ ГРУППЫ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyHWGroup()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyHWGroup());
        }
    }
}