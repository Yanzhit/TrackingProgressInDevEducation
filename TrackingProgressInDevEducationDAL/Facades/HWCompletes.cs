using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class HWCompletes : AFacade, IHWCompletes
    {
        private readonly QHWComplete _query  = new();

        /// <summary>
        /// Создать новое Завершенное ДЗ
        /// </summary>
        /// <param name="hWComplete">Объект данных</param>
        /// <returns>Завершенное ДЗ</returns>
        public HWComplete SetNewHWComplete(HWComplete hWComplete)
        {
            return (HWComplete)Manager.Setter.Single(_query.SetNewHWComplete(hWComplete));
        }

        public IEnumerable<HWComplete> GetHomeWorkProcedureScore()
        {
            return (IEnumerable<HWComplete>)Manager.Getter.Several(_query.GetHomeWorkProcedureScore());
        }

        /// <summary>
        /// Обнуление таблицы Завершенного ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HWComplete> NullifyHWComplete()
        {
            return (IEnumerable<HWComplete>)Manager.Remove.Rem(_query.NullifyHWComplete());
        }
    }
}