using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;


namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class GetByIdComment:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }
        public GetByIdComment()
        {
            Type = typeof(Comments);
            Name = "GetByIdComment";
            Command = "";
        }
    }
    }

