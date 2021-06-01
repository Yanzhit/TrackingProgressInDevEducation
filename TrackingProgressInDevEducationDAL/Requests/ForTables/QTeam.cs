using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewTeam, NullifyTeams))
namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    /// <summary>
    /// Запросы к таблицы команд
    /// </summary>
    public class QTeam : IQuery
    {
        public Type Type { get; } = typeof(Team);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового команды
        /// </summary>
        /// <param name="name">Название команды</param>
        /// <returns>Подготовленный запрос</returns>
        public QTeam SetNewTeam(string name)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(SetNewTeam);
            Params = $"{name}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы команд и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QTeam NullifyTeams()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyTeams);
            Params = string.Empty;
            return this;
        }

        //public QTeam GetTeams()
        //{
        //    TypeQueries = TypeQueries.GetSeveral;
        //    Name = nameof(GetTeams);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QTeam GetTeamById(int id)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetTeamById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QTeam UpdateTeamById(int id, string name)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateTeamById);
        //    Params = $"{id}{Sep}{name}";
        //    return this;
        //}
        //public QTeam RemoveTeamById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveTeamById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QTeam GetAllTeamsByLector(int lectorId)
        //{
        //    TypeQueries = TypeQueries.GetSeveral;
        //    Name = GetType().Name;
        //    Params = $"{lectorId}";
        //    return this;
        //}
    }
}