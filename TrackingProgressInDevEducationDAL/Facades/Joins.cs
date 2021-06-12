using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Joins : AFacade 
    {
        private readonly QJoins _query  = new();
        public IEnumerable<Joins> GetAllCoursesByLectorJ()
        {
            return (IEnumerable<Joins>) Manager.Getter.Several(_query.GetAllCoursesByLectorJ());
        }

        public IEnumerable<Joins> GetAllStudentsByTeamJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetAllStudentsByTeamJ());
        }

        public IEnumerable<GetAllTeamsByLectorJ> GetAllTeamsByLectorJ(GetAllTeamsByLectorJ model)
        {
            return (IEnumerable<GetAllTeamsByLectorJ>)Manager.Getter.Several(_query.GetAllTeamsByLectorJ(model));
        }

        public IEnumerable<Joins> GetAllTestsByStudentIdJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetAllTestsByStudentIdJ());
        }

        public GetGroupByIdJ GetGroupByIdJ(GetGroupByIdJ model)
        {
            return (GetGroupByIdJ)Manager.Getter.Single(_query.GetGroupByIdJ(model));
        }
        public IEnumerable<GetGroupByLectorJ> GetGroupByLectorJ(GetGroupByLectorJ lector)
        {
            return (IEnumerable<GetGroupByLectorJ>)Manager.Getter.Several(_query.GetGroupsByLectorJ(lector));
        }
        public IEnumerable<GetAllStudentsByGroup> GetAllStudentsByGroup(GetAllStudentsByGroup getAllStudentsByGroup)
        {
            return (IEnumerable<GetAllStudentsByGroup>)Manager.Getter.Several(_query.GetAllStudentsByGroup(getAllStudentsByGroup));
        }
        public IEnumerable<GetAllCoursesByGroup> GetAllCoursesByGroup(GetAllCoursesByGroup getAllCoursesByGroup)
        {
            return (IEnumerable<GetAllCoursesByGroup>)Manager.Getter.Several(_query.GetAllCoursesByGroup(getAllCoursesByGroup));
        }

        public IEnumerable<Joins> GetHWComplitingByStudentJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetHWComplitingByStudentJ());
        }

        public IEnumerable<Joins> GetNotActualTeamByStudentIdJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetNotActualTeamByStudentIdJ());
        }

        public IEnumerable<Joins> GetStudentByIdJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetStudentByIdJ());
        }

        public IEnumerable<Joins> GetVisitsByStudentJ()
        {
            return (IEnumerable<Joins>)Manager.Getter.Several(_query.GetVisitsByStudentJ());
        }
    }
}