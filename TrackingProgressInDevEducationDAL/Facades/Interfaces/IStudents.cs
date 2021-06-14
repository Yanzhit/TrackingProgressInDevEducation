using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface IStudents
    {
        Student SetNewStudent(Student student);
        IEnumerable<GetAllStudentsJ> UpdStudentToGroup();
        IEnumerable<GetAllStudentsJ> NullifyStudents();
    }
}