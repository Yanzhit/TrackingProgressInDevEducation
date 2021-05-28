using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableComments
{
    public class UpdateCommentById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateCommentById(int id, string text)
        {
            Type = typeof(Models.Bases.Students);
            Name = GetType().Name;
            Params = $"{id}, {text}";
        }
    }
}
