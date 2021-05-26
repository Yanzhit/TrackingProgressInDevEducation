using TrackingProgressInDevEducationDAL.Requests;

namespace TrackingProgressInDevEducationDAL
{
    public class Queries
    {
        public AddNewStudent AddNewStudent { get; set; }
        public GetByIdStudent GetByIdStudent { get; set; }
        public GetStudents GetStudents { get; set; }
        public RemoveStudents RemoveStudents { get; set; }

        public Queries()
        {
            AddNewStudent = new AddNewStudent();
            GetStudents = new GetStudents();
            RemoveStudents = new RemoveStudents();
        }
        public Queries(int id)
        {
            GetByIdStudent = new GetByIdStudent(id);
        }
    }
}