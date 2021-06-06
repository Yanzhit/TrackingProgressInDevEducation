using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;

//ZLoo (Свойства все, Методы(SetNewCity, GetAllCities, NullifyCities))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы Cities
    /// </summary>
    public class QCity : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(City);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового города
        /// </summary>
        /// <param name="city">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QCity SetNewCity(City city)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewCity);
            Params = $"{city.Name}";
            return this;
        }

        /// <summary>
        /// Получение всех городов из таблицы
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QCity GetAllCities()
        {
            QueryType = typeof(City);
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
            QueryType = typeof(Remove);
            Name = nameof(NullifyCities);
            Params = string.Empty;
            return this;
        }

        //public QCity GetCityById(int id)
        //{
        //    Name = nameof(GetCityById);
        //    Params = $"{id}";
        //    return this;
        //}

        //public QCity RemoveCityById(int id)
        //{
        //    Name = nameof(RemoveCityById);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}