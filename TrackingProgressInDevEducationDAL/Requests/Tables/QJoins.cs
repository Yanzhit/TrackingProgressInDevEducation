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

        public QJoins GetAllStudentsByGroup(GetAllStudentsByGroup getAllStudentsByGroup)
        {
            ModelType = typeof(GetAllStudentsByGroup);
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudentsByGroup);
            Params = $"{SepStr}{getAllStudentsByGroup.Id}{SepEnd}";
            return this;
        }
        public QJoins GetAllCoursesByLectorJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllCoursesByLectorJ);
            Params = "";
            return this;
        }
        public QJoins GetAllCoursesByGroup(GetAllCoursesByGroup getAllCoursesByGroup)
        {
            ModelType = typeof(GetAllCoursesByGroup);
            QueryType = typeof(Getter);
            Name = nameof(GetAllCoursesByGroup);
            Params = $"{SepStr}{getAllCoursesByGroup.Id}{SepEnd}";
            return this;
        }

        public QJoins GetAllStudentsByTeamJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudentsByTeamJ);
            Params = "";
            return this;
        }
        public QJoins GetAllTeamsByLectorJ(GetAllTeamsByLectorJ lectorJ)
        {
            ModelType = typeof(GetAllTeamsByLectorJ);
            QueryType = typeof(Getter);
            Name = nameof(GetAllTeamsByLectorJ);
            Params = $"{SepStr}{lectorJ.Id}{SepEnd}";
            return this;
        }
        public QJoins GetAllTestsByStudentIdJ()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllTestsByStudentIdJ);
            Params = "";
            return this;
        }
        public QJoins GetGroupByIdJ(GetGroupByIdJ groupJ)
        {
            ModelType = typeof(GetGroupByIdJ);
            QueryType = typeof(Getter);
            Name = nameof(GetGroupByIdJ);
            Params = $"{SepStr}{groupJ.Id}{SepEnd}";
            return this;
        }
        public QJoins GetGroupsByLectorJ(GetGroupByLectorJ lector)
        {
            ModelType = typeof(GetGroupByLectorJ);
            QueryType = typeof(Getter);
            Name = nameof(GetGroupsByLectorJ);
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
        public QJoins GetVisitsByStudentJ(GetVisitsByStudentJ model)
        {
            ModelType = typeof(GetVisitsByStudentJ);
            QueryType = typeof(Getter);
            Name = nameof(GetVisitsByStudentJ);
            Params = $"{SepStr}{model.StudentId}{SepEnd}";
            return this;
        }

    }
}