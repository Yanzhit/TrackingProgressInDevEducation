using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class RemoveCommentById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public RemoveCommentById(int id)
        {
            Type = typeof(Comments);
            Name = "RemoveCommentById";
            Params = $"{id}";
        }
    }
}
