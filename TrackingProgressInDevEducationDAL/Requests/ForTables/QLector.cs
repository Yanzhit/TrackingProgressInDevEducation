using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QLector : IQuery
    {
        public Type Type { get; } = typeof(Lector);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLector AddEmailAndPasswordLectors(int id, string email, string password)
        {
            Name = nameof(AddEmailAndPasswordLectors);
            Params = $"{id}, {email}, {password}";
            return this;
        }

        public QLector AddNewLector(string fullName)
        {
            Name = nameof(AddNewLector);
            Params = $"{fullName}";
            return this;
        }
        public QLector GetLectorById(int id)
        {
            Name = nameof(GetLectorById);
            Params = $"{id}";
            return this;
        }
        public QLector GetLectors()
        {
            Name = nameof(GetLectors);
            Params = string.Empty;
            return this;
        }
        public QLector RemoveLectorById(int id)
        {
            Name = nameof(RemoveLectorById);
            Params = $"{id}";
            return this;
        }
        public QLector UpdateLectorById(int id, string fullName)
        {
            Name = nameof(UpdateLectorById);
            Params = $"{id}, {fullName}";
            return this;
        }
        public QLector NullifyLectors()
        {
            Name = nameof(NullifyLectors);
            Params = string.Empty;
            return this;
        }
    }
}