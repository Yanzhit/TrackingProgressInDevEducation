using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class GetGroups:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetGroups()
        {
            Type = typeof(Groups);
            Name = "GetGroups";
            Params = "";
        }
    }
}
