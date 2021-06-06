using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
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
        /// <param name="hwGroup">Объект данных</param>
        /// <returns>ДЗ ГРУППЫ</returns>
        public HWGroup SetNewHWGroup(HWGroup hwGroup)
        {
            return (HWGroup)Manager.Setter.Single(_query.SetNewHWGroup(hwGroup));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ ГРУППЫ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HWGroup> NullifyHWGroup()
        {
            return (IEnumerable<HWGroup>)Manager.Remove.Rem(_query.NullifyHWGroup());
        }
    }
}