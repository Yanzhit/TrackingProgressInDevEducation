using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using TrackingProgressInDevEducationDAL.Requests.NoParams;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Facade
    {
        //Шаблон
        public List<Students> GetStudents()
        {
            GetStudents getStudents = new GetStudents();
            return (List<Students>)QuerySettings.QuerySet((IQuery)getStudents);
        }
    }
}