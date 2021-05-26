using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class GetComments:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }
        public GetComments()
        {
            Type = typeof(Comments);
            Name = "GetComments";
            Command = "";
        }
    }
}
