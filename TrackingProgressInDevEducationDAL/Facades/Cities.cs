using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Cities
    {
        private readonly QCity _qCity = new();
        private readonly QuerySettings _query = new();

        public City SetNewCity(string name)
        {
            return (City) _query.QuerySet(_qCity.SetNewCity(name));
        }

        public IEnumerable<City> GetAllCities()
        {
            return (List<City>) _query.QuerySet(_qCity.GetAllCities());
        }

        public IEnumerable<City> NullifyCities()
        {
            return (List<City>) _query.QuerySet(_qCity.NullifyCities());
        }
    }
}