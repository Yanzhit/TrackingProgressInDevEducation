using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewHW, NullifyHWs)
namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    /// <summary>
    /// 
    /// </summary>
    public class QHomework : IQuery
    {
        public Type Type { get; } = typeof(Homework);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Запросы к таблице домашних заданий
        /// </summary>
        /// <param name="name">Название домашнего задания</param>
        /// <returns>Подготовленный запрос</returns>
        public QHomework SetNewHW(string name)
        {
            TypeQueries = TypeQueries.Single;
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
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyHWs);
            Params = string.Empty;
            return this;
        }

        //public QHomework GetHomeworkById(int id)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetHomeworkById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QHomework RemoveHomeworksById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveHomeworksById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QHomework UpdateHomeworkById(string name, int id)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateHomeworkById);
        //    Params = $"{name}{Sep}{id}";
        //    return this;
        //}
    }
}