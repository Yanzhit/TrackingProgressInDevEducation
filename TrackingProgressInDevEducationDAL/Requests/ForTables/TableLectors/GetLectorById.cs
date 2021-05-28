using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableLectors
{
    public class GetLectorById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetLectorById(int id)
        {
            Type = typeof(Lectors);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
