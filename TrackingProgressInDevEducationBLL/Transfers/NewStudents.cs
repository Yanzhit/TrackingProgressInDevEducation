using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    public class NewStudents : ATransfer
    {
        public NewStudents SetNewStudent()
        {
            Query = typeof(SetNewStudentQ);
            Base = typeof(Student);
            Answer = typeof(SetNewStudentA);
            return this;
        }

        public NewStudents GetCities()
        {
            Query = typeof(EmptyQ);
            Base = typeof(City);
            Answer = typeof(GetCityA);
            return this;
        }

        public NewStudents GetGroups()
        {
            Query = typeof(EmptyQ);
            Base = typeof(Group);
            Answer = typeof(GetGroupsA);
            return this;
        }
    }
}