using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

//ZLoo (Свойства все, Методы(SetNewHW, NullifyHWs)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// 
    /// </summary>
    public class QHomework : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Homework);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Запросы к таблице домашних заданий
        /// </summary>
        /// <param name="homework">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QHomework SetNewHW(Homework homework)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewHW);
            Params = $"{SepStr}{homework.Name}{SepEnd}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы домашних заданий и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QHomework NullifyHWs()
        {
            QueryType = typeof(Remove);
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