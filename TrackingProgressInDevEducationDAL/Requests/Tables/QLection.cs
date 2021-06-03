using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewLection, GetAllLector, NullifyLections))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице лекций групп
    /// </summary>
    public class QLection : IQuery
    {
        public Type Type { get; } = typeof(Lection);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создания новую лекцию
        /// </summary>
        /// <param name="groupId">id групп</param>
        /// <param name="lectorId">id преподавателя</param>
        /// <param name="startedOn">Дата начала</param>
        /// <returns>Подготовленный запрос</returns>
        public QLection SetNewLection(int groupId, int lectorId, DateTime startedOn)
        {
            Name = nameof(SetNewLection);
            Params = $"{groupId}{Sep}{lectorId}{Sep}{startedOn}";
            return this;
        }

        /// <summary>
        /// Получить все лекции
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QLection GetAllLector()
        {
            Name = nameof(GetAllLector);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы лекций и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QLection NullifyLections()
        {
            Name = nameof(NullifyLections);
            Params = string.Empty;
            return this;
        }
    }
}