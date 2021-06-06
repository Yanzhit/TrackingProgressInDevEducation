using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Tests : AFacade
    {
        private readonly QTest _query = new();
   
        public IEnumerable<Test> SetNewTest()
        {
            return (IEnumerable<Test>)Manager.Setter.Single(_query.SetNewTest());
        }

        public IEnumerable<Test> NullifyTests()
        {
            return (IEnumerable<Test>)Manager.Remove.Rem(_query.NullifyTests());
        }
    }
}