using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QVisit : IQuery
    {
        public Type Type { get; } = typeof(Visit);
        public string Name { get; set; }
        public string Params { get; set; }

        public QVisit AddNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            Name = nameof(AddNewVisit);
            Params = $"{visitStatus}, {studentId}, {lectionId}";
            return this;
        }
        public QVisit GetVisitById(int id)
        {
            Name = nameof(GetVisitById);
            Params = $"{id}";
            return this;
        }
        public QVisit GetVisits()
        {
            Name = nameof(GetVisits);
            Params = string.Empty;
            return this;
        }
        public QVisit RemoveVisitById(int id)
        {
            Name = nameof(RemoveVisitById);
            Params = $"{id}";
            return this;
        }
        public QVisit UpdateVisitById(int id, bool visitStatus, int studentId, int lectionId)
        {
            Name = nameof(UpdateVisitById);
            Params = $"{id}, {visitStatus}, {studentId}, {lectionId}";
            return this;
        }
        public QVisit NullifyVisits()
        {
            Name = nameof(NullifyVisits);
            Params = string.Empty;
            return this;
        }
    }
}