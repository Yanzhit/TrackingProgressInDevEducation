using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Params;

namespace TrackingProgressInDevEducationDAL.Facades.ForTables
{
    public class FacadeHomeworks
    {

    }

    public class FacadeCreateNewHomeworks
    {
        public List<Homeworks> CreateNewHomeworks(string name)
        {
            CreateNewHomeworks createNewHomeworks = new CreateNewHomeworks(name);
            return (List<Homeworks>)QuerySettings.QuerySet(createNewHomeworks);
        }
    }

}