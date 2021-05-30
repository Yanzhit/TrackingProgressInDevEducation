using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QVisit : IQuery
    {
        public Type Type { get; } = typeof(Visit);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QVisit AddNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(AddNewVisit);
            Params = $"{visitStatus}, {studentId}, {lectionId}";
            return this;
        }
        public QVisit GetVisitById(int id)
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetVisitById);
            Params = $"{id}";
            return this;
        }
        public QVisit GetVisits()
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetVisits);
            Params = string.Empty;
            return this;
        }
        public QVisit RemoveVisitById(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveVisitById);
            Params = $"{id}";
            return this;
        }
        public QVisit UpdateVisitById(int id, bool visitStatus, int studentId, int lectionId)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateVisitById);
            Params = $"{id}, {visitStatus}, {studentId}, {lectionId}";
            return this;
        }
        public QVisit NullifyVisits()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyVisits);
            Params = string.Empty;
            return this;
        }
    }
}