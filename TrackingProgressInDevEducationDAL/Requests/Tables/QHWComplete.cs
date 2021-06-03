using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewHWComplete, NullifyHWComplete)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице завершенных домашних заданий
    /// </summary>
    public class QHWComplete : IQuery
    {
        public Type Type { get; } = typeof(HWComplete);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового завершенного домашнего задания
        /// </summary>
        /// <param name="homeworkId">id домашнего задания</param>
        /// <param name="studentId">id студента, на которого назначено домашнее задание</param>
        /// <param name="status">Статус выполнения домашнего задания (1;0)</param>
        /// <returns>Подготовленный запрос</returns>
        public QHWComplete SetNewHWComplete(int homeworkId, int studentId, bool status)
        {
            Name = nameof(SetNewHWComplete);
            Params = $"{homeworkId}{Sep}{studentId}{Sep}{status}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы завершенных домашних заданий и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QHWComplete NullifyHWComplete()
        {
            Name = nameof(NullifyHWComplete);
            Params = string.Empty;
            return this;
        }

        //public QHWComplete UpdateHWCompleteByIdHW(int homeworkId, bool status)
        //{
        //    Name = nameof(UpdateHWCompleteByIdHW);
        //    Params = $"{homeworkId}{Sep}{status}";
        //    return this;
        //}
        //public QHWComplete UpdateHWCompleteByIdStudents(int studentId, bool status)
        //{
        //    Name = nameof(UpdateHWCompleteByIdStudents);
        //    Params = $"{studentId}{Sep}{status}";
        //    return this;
        //}
    }
}