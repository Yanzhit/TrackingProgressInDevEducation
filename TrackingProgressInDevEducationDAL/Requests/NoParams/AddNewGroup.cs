using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class AddNewGroup:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public AddNewGroup()
        {
            Type = typeof(Groups);
            Name = "AddNewGroup";
            Command = "";
        }
    }
}
