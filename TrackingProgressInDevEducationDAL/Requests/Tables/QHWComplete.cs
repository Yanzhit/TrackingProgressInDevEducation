using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewHWComplete, NullifyHWComplete)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице завершенных домашних заданий
    /// </summary>
    public class QHWComplete : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(HWComplete);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового завершенного домашнего задания
        /// </summary>
        /// <param name="hwComplete">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QHWComplete SetNewHWComplete(HWComplete hwComplete)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewHWComplete);
            Params = $"{SepStr}{hwComplete.HomeworkId}{SepMid}{hwComplete.StudentId}{SepMid}{hwComplete.Status}{SepEnd}";
            return this;
        }

        public QHWComplete GetHomeWorkProcedureScore()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetHomeWorkProcedureScore);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы завершенных домашних заданий и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QHWComplete NullifyHWComplete()
        {
            QueryType = typeof(Remove);
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