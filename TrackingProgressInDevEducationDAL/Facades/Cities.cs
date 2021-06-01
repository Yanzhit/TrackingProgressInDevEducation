using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstarcts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Cities : AFacade
    {
        public QCity Query { get; set; }
        public City SetNewCity(string name)
        {
        
            return (City) _querySet.QuerySet(Query.SetNewCity(name));
        }

        public IEnumerable<City> GetAllCities()
        {
            return (List<City>) _querySet.QuerySet(Query.GetAllCities());
        }

        public IEnumerable<City> NullifyCities()
        {
            return (List<City>) _querySet.QuerySet(Query.NullifyCities());
        }
    }
}