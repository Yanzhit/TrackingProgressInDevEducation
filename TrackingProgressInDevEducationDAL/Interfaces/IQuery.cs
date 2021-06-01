using System;

//ZLoo (Все ок)
namespace TrackingProgressInDevEducationDAL.Interfaces
{
    public interface IQuery
    {
        /// <summary>
        /// Тайп модели на базе которой работаем
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Тип запроса(Set, Get, Upd, Remove, Nullify) для работы с одним, либо несколькими объектами
        /// </summary>
        TypeQueries TypeQueries { get; set; }

        /// <summary>
        /// Название процедуры(Берется из названия метода) не допускается различий
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Параметры запросов
        /// </summary>
        string Params { get; set; }
    }
}