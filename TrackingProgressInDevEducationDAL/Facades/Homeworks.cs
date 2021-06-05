using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Homeworks : AFacade
    {
        private readonly QHomework _query  = new();

        /// <summary>
        /// Создать новое ДЗ
        /// </summary>
        /// <param name="name">Имя ДЗ</param>
        /// <returns>ДЗ</returns>
        public AResult SetNewHW(string name)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewHW(name));
        }

        /// <summary>
        /// Обнуление таблицы ДЗ и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyHWs()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyHWs());
        }
    }
}