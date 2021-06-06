using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QTestComplete : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(TestComplete);
        public string Name { get; set; }
        public string Params { get; set; }

        public QTestComplete SetNewTC()
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewTC);
            Params = "";
            return this;
        }

        public QTestComplete GetTestScore()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetTestScore);
            Params = "";
            return this;
        }

        public QTestComplete NullifyTCs()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyTCs);
            Params = "";
            return this;
        }
    }
}