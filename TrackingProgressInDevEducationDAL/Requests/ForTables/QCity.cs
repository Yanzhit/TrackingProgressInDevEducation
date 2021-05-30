using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QCity : IQuery
    {
        public Type Type { get; }  = typeof(City);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QCity SetNewCity(string name)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(SetNewCity);
            Params = $"{name}";
            return this;
        }

        public QCity GetCities()
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetCities);
            Params = string.Empty;
            return this;
        }

        public QCity GetCityById(int id)
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetCityById);
            Params = $"{id}";
            return this;
        }

        public QCity RemoveCityById(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveCityById);
            Params = $"{id}";
            return this;
        }


        public QCity NullifyCities()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyCities);
            Params = string.Empty;
            return this;
        }
    }
}