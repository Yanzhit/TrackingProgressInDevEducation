using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableComments
{
    public class GetByIdComment : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }
        public GetByIdComment(int id)
        {
            Type = typeof(Models.Bases.Comments);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}

