using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewHWComplete, NullifyHWComplete)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице завершенных домашних заданий
    /// </summary>
    public class QHomeworkComplete : IQuery
    {
        public Type Type { get; } = typeof(HWComplete);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового завершенного домашнего задания
        /// </summary>
        /// <param name="homeworkId">id домашнего задания</param>
        /// <param name="studentId">id студента, на которого назначено домашнее задание</param>
        /// <param name="status">Статус выполнения домашнего задания (1;0)</param>
        /// <returns>Подготовленный запрос</returns>
        public QHomeworkComplete SetNewHWComplete(int homeworkId, int studentId, bool status)
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewHWComplete);
            Params = $"{homeworkId}{Sep}{studentId}{Sep}{status}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы завершенных домашних заданий и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QHomeworkComplete NullifyHWComplete()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyHWComplete);
            Params = string.Empty;
            return this;
        }

        //public QHomeworkComplete UpdateHWCompleteByIdHW(int homeworkId, bool status)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateHWCompleteByIdHW);
        //    Params = $"{homeworkId}{Sep}{status}";
        //    return this;
        //}
        //public QHomeworkComplete UpdateHWCompleteByIdStudents(int studentId, bool status)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateHWCompleteByIdStudents);
        //    Params = $"{studentId}{Sep}{status}";
        //    return this;
        //}
    }
}