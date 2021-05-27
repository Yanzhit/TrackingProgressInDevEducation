using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
  public  class AddNewComment: IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewComment(string Text,int TypeId,int StudentId, int CreatedBy)
        {
            Type = typeof(Comments);
            Name = "AddNewComment";
            Params = $"{Text},{TypeId},{StudentId},{CreatedBy}";
        }
    }

}
