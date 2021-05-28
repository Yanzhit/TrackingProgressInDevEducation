using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableComments
{
    public  class GetComments : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetComments()
        {
            Type = typeof(Models.Bases.Comments);
            Name = GetType().Name;
            Params = string.Empty;
        }
    }
}
