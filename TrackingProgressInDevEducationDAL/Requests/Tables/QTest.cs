using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QTest : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; } = typeof(Test);
        public string Name { get; set; }
        public string Params { get; set; }

        public QTest SetNewTest()
        {
            Type = typeof(Setter);
            Name = nameof(SetNewTest);
            Params = "";
            return this;
        }

        public QTest NullifyTests()
        {
            Type = typeof(Remove);
            Name = nameof(NullifyTests);
            Params = "";
            return this;
        }
    }
}