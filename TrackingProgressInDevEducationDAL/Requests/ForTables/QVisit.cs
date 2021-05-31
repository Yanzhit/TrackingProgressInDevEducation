using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QVisit : IQuery
    {
        public Type Type { get; } = typeof(Visit);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QVisit AddNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewVisit);
            Params = $"{visitStatus}{Sep}{studentId}{Sep}{lectionId}";
            return this;
        }
        public QVisit GetVisitById(int id)
        {
            TypeQueries = TypeQueries.GetOne;
            Name = nameof(GetVisitById);
            Params = $"{id}";
            return this;
        }
        public QVisit GetVisits()
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetVisits);
            Params = string.Empty;
            return this;
        }
        public QVisit RemoveVisitById(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemoveVisitById);
            Params = $"{id}";
            return this;
        }
        public QVisit UpdateVisitById(int id, bool visitStatus, int studentId, int lectionId)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateVisitById);
            Params = $"{id}{Sep}{visitStatus}{Sep}{studentId}{Sep}{lectionId}";
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