using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
//ZLoo (Свойства все, Методы(SetNewCity, GetAllCities, NullifyCities))
namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    /// <summary>
    /// Запросы для таблицы Cities
    /// </summary>
    public class QCity : IQuery
    {
        public Type Type { get; } = typeof(City);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового города
        /// </summary>
        /// <param name="name">Название города</param>
        /// <returns>Подготовленный запрос</returns>
        public QCity SetNewCity(string name)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(SetNewCity);
            Params = $"{name}";
            return this;
        }

        /// <summary>
        /// Получение всех городов из таблицы
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QCity GetAllCities()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetAllCities);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QCity NullifyCities()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyCities);
            Params = string.Empty;
            return this;
        }

        //public QCity GetCityById(int id)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetCityById);
        //    Params = $"{id}";
        //    return this;
        //}

        //public QCity RemoveCityById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveCityById);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}