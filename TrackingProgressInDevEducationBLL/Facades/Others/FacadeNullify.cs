using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Requests.Nullify;

namespace TrackingProgressInDevEducationBLL.Facades.Others
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