using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class UpdateCommentById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateCommentById(int id, string text)
        {
            Type = typeof(Students);
            Name = GetType().Name;
            Params = $"{id}, {text}";
        }
    }
}
