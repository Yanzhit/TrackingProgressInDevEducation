using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLector : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Lector);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLector SetNewLector(string fullName, string email, string password)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewLector);
            Params = @$"{SepStr}{fullName}{SepMid}{email}{SepMid}{password}{SepEnd}";
            return this;
        }

        public QLector GetLectorById(int id)
        {
            QueryType = typeof(Getter);
            Name = nameof(GetLectorById);
            Params = $"{id}";
            return this;
        }

        public QLector GetLoginAndPassword(Lector model)
        {
            QueryType = typeof(Getter);
            Name = nameof(GetLoginAndPassword);
            Params = $"{SepStr}{model.Email}{SepMid}{model.Password}{SepEnd}";
            return this;
        }

        public QLector GetAllLectors()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllLectors);
            Params = string.Empty;
            return this;
        }

        public QLector UpdateAcrivationLector(int id, bool isActive)
        {
            QueryType = typeof(Update);
            Name = nameof(UpdateAcrivationLector);
            Params = $"{SepStr}{id}{SepMid}{isActive}{SepEnd}";
            return this;
        }

        public QLector UpdNewEmailAndPasswordLectors()
        {
            QueryType = typeof(Update);
            Name = nameof(UpdNewEmailAndPasswordLectors);
            Params = $"";
            return this;
        }

        public QLector NullifyLectors()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyLectors);
            Params = string.Empty;
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