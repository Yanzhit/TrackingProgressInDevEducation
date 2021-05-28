using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeStudents
    {
    }

    public class FacadeAddNewStudent
    {
        public string AddNewStudent(string name, string surname, decimal rate)
        {
            AddNewStudent addNewStudent = new AddNewStudent(name, surname, rate);
            return (string) QuerySettings.QuerySet(addNewStudent);
        }
    }
}