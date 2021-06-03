using System;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QJoins : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QJoins GetAllCoursesByLectorJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetAllCoursesByLectorJ);
            Params = "";
            return this;
        }

        public QJoins GetAllStudentsByTeamJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetAllStudentsByTeamJ);
            Params = "";
            return this;
        }
        public QJoins GetAllTeamsByLectorJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetAllTeamsByLectorJ);
            Params = "";
            return this;
        }
        public QJoins GetAllTestsByStudentIdJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetAllTestsByStudentIdJ);
            Params = "";
            return this;
        }
        public QJoins GetGroupByIdJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetGroupByIdJ);
            Params = "";
            return this;
        }
        public QJoins GetHWComplitingByStudentJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetHWComplitingByStudentJ);
            Params = "";
            return this;
        }
        public QJoins GetNotActualTeamByStudentIdJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetNotActualTeamByStudentIdJ);
            Params = "";
            return this;
        }
        public QJoins GetStudentByIdJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetStudentByIdJ);
            Params = "";
            return this;
        }
        public QJoins GetVisitsByStudentJ()
        {
            Type = typeof(Getter);
            Name = nameof(GetVisitsByStudentJ);
            Params = "";
            return this;
        }

    }
}