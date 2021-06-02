using System;

namespace TrackingProgressInDevEducationDAL.Tests.Abstract
{
    public abstract class ATTests
    {
        /// <summary>
        /// Фасад запросов
        /// </summary>
        protected readonly ManagerQueries _manager = new();

        /// <summary>
        /// Очистка и заполнение базы данных по входящему типу модели
        /// </summary>
        /// <param name="type">Тип модели, построена на основе модели</param>
        protected void PreparindDB(Type type)
        {
            var preparation = new PreparationDB();
            preparation.Nullify(type);
            preparation.Filling(type);
        }
    }
}