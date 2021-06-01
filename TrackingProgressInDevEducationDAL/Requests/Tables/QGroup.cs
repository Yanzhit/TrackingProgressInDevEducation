using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewGroup, NullifyGroups)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице групп
    /// </summary>
    public class QGroup : IQuery
    {
        public Type Type { get; } = typeof(Group);
        public TypeQueries TypeQueries { get; set; }
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
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewGroup);
            Params = $"{name}{Sep}{courseId}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы групп и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QGroup NullifyGroups()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyGroups);
            Params = string.Empty;
            return this;
        }

        //public QGroup GetGroupById(int id)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetGroupById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QGroup GetGroups()
        //{
        //    TypeQueries = TypeQueries.GetSeveral;
        //    Name = nameof(GetGroups);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QGroup RemoveGroupById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveGroupById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QGroup UpdateGroupById(int id, string name, int courseId)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateGroupById);
        //    Params = $"{id}{Sep}{name}{Sep}{courseId}";
        //    return this;
        //}
        //public QGroup GetGroupsByLector(int lectorId)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = GetType().Name;
        //    Params = $"{lectorId}";
        //    return this;
        //}
    }
}