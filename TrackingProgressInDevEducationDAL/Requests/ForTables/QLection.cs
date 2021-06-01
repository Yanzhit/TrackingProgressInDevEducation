using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewLection, GetAllLector, NullifyLections))
namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    /// <summary>
    /// Запросы к таблице лекций групп
    /// </summary>
    public class QLection : IQuery
    {
        public Type Type { get; } = typeof(Lection);
        public TypeQueries TypeQueries { get; set; }
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
            TypeQueries = TypeQueries.SetOne;
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
            TypeQueries = TypeQueries.SetSeveral;
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
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyLections);
            Params = string.Empty;
            return this;
        }
    }
}