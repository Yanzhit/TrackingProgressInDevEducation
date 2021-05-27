using TrackingProgressInDevEducationDAL.Requests.NoParams;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL
{
    public class Queries
    {
        public AddNewStudent AddNewStudent { get; }
        public GetByIdStudent GetByIdStudent { get; }
        public GetStudents GetStudents { get; }
        public RemoveStudents RemoveStudents { get; }

        public Queries()
        {
            GetStudents = new GetStudents();
            RemoveStudents = new RemoveStudents();
        }
        public Queries(int id)
        {
            GetByIdStudent = new GetByIdStudent(id);
        }

        public Queries(string name, string surname, decimal rate)
        {
            AddNewStudent = new AddNewStudent(name, surname, rate);
        }
    }
}