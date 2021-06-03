using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

//ZLoo (Свойства все, Методы(SetNewHW, NullifyHWs)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// 
    /// </summary>
    public class QHomework : IQuery
    {
        public Type Type { get; } = typeof(Homework);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Запросы к таблице домашних заданий
        /// </summary>
        /// <param name="name">Название домашнего задания</param>
        /// <returns>Подготовленный запрос</returns>
        public QHomework SetNewHW(string name)
        {
            Name = nameof(SetNewHW);
            Params = $"{name}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы домашних заданий и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QHomework NullifyHWs()
        {
            Name = nameof(NullifyHWs);
            Params = string.Empty;
            return this;
        }

        //public QHomework GetHomeworkById(int id)
        //{
        //    Name = nameof(GetHomeworkById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QHomework RemoveHomeworksById(int id)
        //{
        //    Name = nameof(RemoveHomeworksById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QHomework UpdateHomeworkById(string name, int id)
        //{
        //    Name = nameof(UpdateHomeworkById);
        //    Params = $"{name}{Sep}{id}";
        //    return this;
        //}
    }
}