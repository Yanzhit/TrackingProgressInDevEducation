using TrackingProgressInDevEducationDAL.Requests.Nullify;

namespace TrackingProgressInDevEducationDAL.Facades.Others
{
    public class FacadeNullify
    {
    }
    

    public class FacadeNullifyStudents
    {
        public string NullifyStudents()
        {
            NullifyStudents nullifyStudents = new NullifyStudents();
            return (string)QuerySettings.QuerySet(nullifyStudents);
        }
    }
}