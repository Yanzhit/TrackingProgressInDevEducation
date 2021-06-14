using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

//ZLoo (Свойства все, Методы(SetNewTeam, NullifyTeams))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблицы команд
    /// </summary>
    public class QTeam : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Team);
        public string Name { get; set; }
        public string Params { get; set; }


        public QTeam GetTeamById(Team team)
        {
            QueryType = typeof(Getter);
            Name = nameof(GetTeamById);
            Params = $"{SepStr}{team.Id}{SepEnd}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы команд и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QTeam NullifyTeams()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyTeams);
            Params = string.Empty;
            return this;
        }

        //public QTeam GetTeams()
        //{
        //    Name = nameof(GetTeams);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QTeam GetTeamById(int id)
        //{
        //    Name = nameof(GetTeamById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QTeam UpdateTeamById(int id, string name)
        //{
        //    Name = nameof(UpdateTeamById);
        //    Params = $"{id}{Sep}{name}";
        //    return this;
        //}
        //public QTeam RemoveTeamById(int id)
        //{
        //    Name = nameof(RemoveTeamById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QTeam GetAllTeamsByLector(int lectorId)
        //{
        //    Name = GetType().Name;
        //    Params = $"{lectorId}";
        //    return this;
        //}
    }
}