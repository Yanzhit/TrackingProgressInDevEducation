using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableComments
{
    public class RemoveCommentById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public RemoveCommentById(int id)
        {
            Type = typeof(Models.Bases.Comments);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
