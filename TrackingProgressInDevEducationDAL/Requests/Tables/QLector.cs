using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLector : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Lector);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLector SetNewLector(Lector lector)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewLector);
            Params = @$"{SepStr}{lector.Login}{SepMid}{lector.FullName}{SepMid}{lector.Email}{SepMid}{lector.Password}{SepEnd}";
            return this;
        }

        public QLector GetLectorById(Lector lector)
        {
            QueryType = typeof(Getter);
            Name = nameof(GetLectorById);
            Params = $"{lector.Id}";
            return this;
        }

        public QLector GetLectorByLoginAndPassword(Lector lector)
        {
            QueryType = typeof(Getter);
            Name = nameof(GetLectorByLoginAndPassword);
            Params = $"{SepStr}{lector.Login}{SepMid}{lector.Password}{SepEnd}";
            return this;
        }

        public QLector GetAllLectors()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllLectors);
            Params = string.Empty;
            return this;
        }

        public QLector UpdateAcrivationLector(Lector lector)
        {
            QueryType = typeof(Update);
            Name = nameof(UpdateAcrivationLector);
            Params = $"{SepStr}{lector.Id}{SepMid}{lector.IsActivated}{SepEnd}";
            return this;
        }

        public QLector UpdEmailLectors(Lector lector)
        {
            QueryType = typeof(Update);
            Name = nameof(UpdEmailLectors);
            Params = $"{SepStr}{lector.Id}{SepMid}{lector.Email}{SepEnd}";
            return this;
        }

        public QLector UpdPasswordLectors(Lector lector)
        {
            QueryType = typeof(Update);
            Name = nameof(UpdPasswordLectors);
            Params = $"{SepStr}{lector.Id}{SepMid}{lector.Password}{SepEnd}";
            return this;
        }

        public QLector UpdLoginLectors(Lector lector)
        {
            QueryType = typeof(Update);
            Name = nameof(UpdLoginLectors);
            Params = $"{SepStr}{lector.Id}{SepMid}{lector.Login}{SepEnd}";
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