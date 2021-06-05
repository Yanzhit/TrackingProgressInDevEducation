using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewGroup, NullifyGroups)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице групп
    /// </summary>
    public class QGroup : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Group);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание новой группы
        /// </summary>
        /// <param name="name">Имя группы</param>
        /// <param name="courseId">id курса</param>
        /// <returns>Подготовленный запрос</returns>
        public QGroup SetNewGroup(string name, int courseId)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewGroup);
            Params = $"{SepStr}{name}{SepMid}{courseId}{SepStr}";
            return this;
        }

        public QGroup GetGroupsByLector(int lectorId)
        {
            QueryType = typeof(Getter);
            Name = GetType().Name;
            Params = $"{SepStr}{lectorId}{SepEnd}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы групп и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QGroup NullifyGroups()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyGroups);
            Params = string.Empty;
            return this;
        }

        //public QGroup GetGroupById(int id)
        //{
        //    Name = nameof(GetGroupById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QGroup GetGroups()
        //{
        //    Name = nameof(GetGroups);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QGroup RemoveGroupById(int id)
        //{
        //    Name = nameof(RemoveGroupById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QGroup UpdateGroupById(int id, string name, int courseId)
        //{
        //    Name = nameof(UpdateGroupById);
        //    Params = $"{id}{Sep}{name}{Sep}{courseId}";
        //    return this;
        //}
        //public QGroup GetGroupsByLector(int lectorId)
        //{
        //    Name = GetType().Name;
        //    Params = $"{lectorId}";
        //    return this;
        //}
    }
}