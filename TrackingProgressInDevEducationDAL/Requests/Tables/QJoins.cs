using System;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QJoins : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QJoins GetAllCoursesByLectorJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllCoursesByLectorJ);
            Params = "";
            return this;
        }

        public QJoins GetAllStudentsByTeamJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudentsByTeamJ);
            Params = "";
            return this;
        }
        public QJoins GetAllTeamsByLectorJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllTeamsByLectorJ);
            Params = "";
            return this;
        }
        public QJoins GetAllTestsByStudentIdJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllTestsByStudentIdJ);
            Params = "";
            return this;
        }
        public QJoins GetGroupByIdJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetGroupByIdJ);
            Params = "";
            return this;
        }
        public QJoins GetGroupByLectorJ(GetGroupByLectorJ lector)
        {
            ModelType = typeof(GetGroupByLectorJ);
            QueryType = typeof(Getter);
            Name = nameof(GetGroupByLectorJ);
            Params = $"{SepStr}{lector.Id}{SepEnd}";
            return this;
        }
        public QJoins GetHWComplitingByStudentJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetHWComplitingByStudentJ);
            Params = "";
            return this;
        }
        public QJoins GetNotActualTeamByStudentIdJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetNotActualTeamByStudentIdJ);
            Params = "";
            return this;
        }
        public QJoins GetStudentByIdJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetStudentByIdJ);
            Params = "";
            return this;
        }
        public QJoins GetVisitsByStudentJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetVisitsByStudentJ);
            Params = "";
            return this;
        }

    }
}