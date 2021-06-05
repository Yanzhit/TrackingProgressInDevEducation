using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewHWGroup, NullifyHWGroup)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице домашних заданий групп
    /// </summary>
    public class QHWGroup : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(HWGroup);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового завершенного домашнего задания групп
        /// </summary>
        /// <param name="homeworkId">id домашнего задания</param>
        /// <param name="groupId">id групп</param>
        /// <returns>Подготовленный запрос</returns>
        public QHWGroup SetNewHWGroup(int homeworkId, int groupId)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewHWGroup);
            Params = $"{SepStr}{homeworkId}{SepMid}{groupId}{SepEnd}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы завершенных домашних заданий групп и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QHWGroup NullifyHWGroup()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyHWGroup);
            Params = string.Empty;
            return this;
        }
    }
}