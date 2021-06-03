using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

//ZLoo (Свойства все, Методы(SetNewCity, GetAllCities, NullifyCities))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы Cities
    /// </summary>
    public class QCity : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; } = typeof(City);

        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового города
        /// </summary>
        /// <param name="name">Название города</param>
        /// <returns>Подготовленный запрос</returns>
        public QCity SetNewCity(string name)
        {
            Type = typeof(Setter);
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
            Type = typeof(City);
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
            Type = typeof(Remove);
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