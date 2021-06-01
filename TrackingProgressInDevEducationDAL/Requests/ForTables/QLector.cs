using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QLector : IQuery
    {
        public Type Type { get; } = typeof(Lector);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QLector SetNewLector(string fullName, string email, string password)
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewLector);
            Params = $"{fullName}{Sep}{email}{Sep}{password}";
            return this;
        }
        public QLector NullifyLectors()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyLectors);
            Params = string.Empty;
            return this;
        }

        public QLector GetLectorById(int id)
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(GetLectorById);
            Params = $"{id}";
            return this;
        }

        //public QLector GetLectors()
        //{
        //    TypeQueries = TypeQueries.GetSeveral;
        //    Name = nameof(GetLectors);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QLector RemoveLectorById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveLectorById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QLector UpdateLectorById(int id, string fullName)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateLectorById);
        //    Params = $"{id}{Sep}{fullName}";
        //    return this;
        //}
    }
}