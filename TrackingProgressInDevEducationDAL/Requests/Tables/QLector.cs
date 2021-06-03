using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLector : IQuery
    {
        public Type Type { get; } = typeof(Lector);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLector SetNewLector(string fullName, string email, string password)
        {
            Name = nameof(SetNewLector);
            Params = $"{fullName}{Sep}{email}{Sep}{password}";
            return this;
        }
        public QLector NullifyLectors()
        {
            Name = nameof(NullifyLectors);
            Params = string.Empty;
            return this;
        }

        public QLector GetLectorById(int id)
        {
            Name = nameof(GetLectorById);
            Params = $"{id}";
            return this;
        }

        //public QLector GetLectors()
        //{
        //    Name = nameof(GetLectors);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QLector RemoveLectorById(int id)
        //{
        //    Name = nameof(RemoveLectorById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QLector UpdateLectorById(int id, string fullName)
        //{
        //    Name = nameof(UpdateLectorById);
        //    Params = $"{id}{Sep}{fullName}";
        //    return this;
        //}
    }
}