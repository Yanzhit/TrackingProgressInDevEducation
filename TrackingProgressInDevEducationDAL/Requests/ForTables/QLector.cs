using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QLector : IQuery
    {
        public Type Type { get; } = typeof(Lector);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QLector AddEmailAndPasswordLectors(int id, string email, string password)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddEmailAndPasswordLectors);
            Params = $"{id}, {email}, {password}";
            return this;
        }

        public QLector AddNewLector(string fullName)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewLector);
            Params = $"{fullName}";
            return this;
        }
        public QLector GetLectorById(int id)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = nameof(GetLectorById);
            Params = $"{id}";
            return this;
        }
        public QLector GetLectors()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetLectors);
            Params = string.Empty;
            return this;
        }
        public QLector RemoveLectorById(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemoveLectorById);
            Params = $"{id}";
            return this;
        }
        public QLector UpdateLectorById(int id, string fullName)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateLectorById);
            Params = $"{id}, {fullName}";
            return this;
        }
        public QLector NullifyLectors()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyLectors);
            Params = string.Empty;
            return this;
        }
    }
}