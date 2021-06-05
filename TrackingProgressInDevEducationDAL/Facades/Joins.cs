using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Joins : AFacade 
    {
        private readonly QJoins _query  = new();
        public IEnumerable<AResult> GetAllCoursesByLectorJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetAllCoursesByLectorJ());
        }

        public IEnumerable<AResult> GetAllStudentsByTeamJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetAllStudentsByTeamJ());
        }

        public IEnumerable<AResult> GetAllTeamsByLectorJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetAllTeamsByLectorJ());
        }

        public IEnumerable<AResult> GetAllTestsByStudentIdJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetAllTestsByStudentIdJ());
        }

        public IEnumerable<AResult> GetGroupByIdJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetGroupByIdJ());
        }

        public IEnumerable<AResult> GetHWComplitingByStudentJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetHWComplitingByStudentJ());
        }

        public IEnumerable<AResult> GetNotActualTeamByStudentIdJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetNotActualTeamByStudentIdJ());
        }

        public IEnumerable<AResult> GetStudentByIdJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetStudentByIdJ());
        }

        public IEnumerable<AResult> GetVisitsByStudentJ()
        {
            return (IEnumerable<AResult>)Manager.Getter.Several(_query.GetVisitsByStudentJ());
        }
    }
}