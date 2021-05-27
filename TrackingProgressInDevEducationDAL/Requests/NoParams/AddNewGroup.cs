using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class AddNewGroup:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewGroup(string Name, int CourseId)
        {
            Type = typeof(Groups);
            Name = "AddNewGroup";
            Params = $"{Name},{CourseId}";
        }
    }
}
