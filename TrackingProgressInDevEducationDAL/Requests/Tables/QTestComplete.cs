using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QTestComplete : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; } = typeof(TestComplete);
        public string Name { get; set; }
        public string Params { get; set; }

        public QTestComplete SetNewTC()
        {
            Type = typeof(Setter);
            Name = nameof(SetNewTC);
            Params = "";
            return this;
        }

        public QTestComplete GetTestScore()
        {
            Type = typeof(Getter);
            Name = nameof(GetTestScore);
            Params = "";
            return this;
        }

        public QTestComplete NullifyTCs()
        {
            Type = typeof(Remove);
            Name = nameof(NullifyTCs);
            Params = "";
            return this;
        }
    }
}