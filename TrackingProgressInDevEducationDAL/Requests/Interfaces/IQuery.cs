using System;

//ZLoo (Все ок)
namespace TrackingProgressInDevEducationDAL.Requests.Interfaces
{
    public interface IQuery
    {
        /// <summary>
        /// Тайп модели на базе которой работаем
        /// </summary>
        Type QueryType { get; set; }

        /// <summary>
        /// Тип модели для Unit тестов
        /// </summary>
        Type ModelType { get; }
        /// <summary>
        /// Название процедуры(Берется из названия метода) не допускается различий
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Параметры запросов
        /// </summary>
        String Params { get; set; }
    }
}