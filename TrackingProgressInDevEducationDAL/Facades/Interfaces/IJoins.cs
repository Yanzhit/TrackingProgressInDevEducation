using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IJoins
    {
        IEnumerable<Joins> GetAllCoursesByLectorJ();
        IEnumerable<Joins> GetAllStudentsByTeamJ();
        IEnumerable<GetAllTeamsByLectorJ> GetAllTeamsByLectorJ(GetAllTeamsByLectorJ model);
        IEnumerable<Joins> GetAllTestsByStudentIdJ();
        GetGroupByIdJ GetGroupByIdJ(GetGroupByIdJ model);
        IEnumerable<GetGroupByLectorJ> GetGroupByLectorJ(GetGroupByLectorJ lector);
        IEnumerable<GetAllStudentsByGroup> GetAllStudentsByGroup(GetAllStudentsByGroup getAllStudentsByGroup);
        IEnumerable<GetAllCoursesByGroup> GetAllCoursesByGroup(GetAllCoursesByGroup getAllCoursesByGroup);
        IEnumerable<Joins> GetHWComplitingByStudentJ();
        IEnumerable<Joins> GetNotActualTeamByStudentIdJ();
        IEnumerable<Joins> GetStudentByIdJ();
        IEnumerable<GetVisitsByStudentJ> GetVisitsByStudentJ(GetVisitsByStudentJ model);
        IEnumerable<GetAllStudentsJ> GetAllStudents();
        SetNewGroupJ SetNewGroupJ(SetNewGroupJ group);
        SetNewTeams SetNewTeams(SetNewTeams team);
    }
}