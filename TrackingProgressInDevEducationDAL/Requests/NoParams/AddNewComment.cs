using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class AddNewComment: IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public AddNewComment()
        {
            Type = typeof(Comments);
            Name = "AddNewComment";
            Command = "";
        }
    }

}
