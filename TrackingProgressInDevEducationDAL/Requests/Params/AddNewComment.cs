using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class AddNewComment: IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewComment(string text,int typeId,int studentId, int createdBy)
        {
            Type = typeof(Comments);
            Name = "AddNewComment";
            Params = $"{text}, {typeId}, {studentId}, {createdBy}";
        }
    }

}
