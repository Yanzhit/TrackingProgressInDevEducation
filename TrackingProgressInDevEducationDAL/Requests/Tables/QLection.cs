using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewLection, GetAllLector, NullifyLections))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице лекций групп
    /// </summary>
    public class QLection : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Lection);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создания новую лекцию
        /// </summary>
        /// <param name="lection">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QLection SetNewLection(Lection lection)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewLection);
            Params = $"{SepStr}{lection.GroupId}{SepMid}{lection.LectorId}{SepMid}{lection.StartedOn}{SepEnd}";
            return this;
        }


        /// <summary>
        /// Обнуление таблицы лекций и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QLection NullifyLections()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyLections);
            Params = string.Empty;
            return this;
        }
    }
}