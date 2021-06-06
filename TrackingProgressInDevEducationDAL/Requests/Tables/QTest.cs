using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QTest : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Test);
        public string Name { get; set; }
        public string Params { get; set; }

        public QTest SetNewTest()
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewTest);
            Params = "";
            return this;
        }

        public QTest NullifyTests()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyTests);
            Params = "";
            return this;
        }
    }
}