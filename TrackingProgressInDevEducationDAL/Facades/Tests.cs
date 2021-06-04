using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Tests : AFacade
    {
        private readonly QTest _query = new();
   
        public IEnumerable<AResult> SetNewTest()
        {
            return (IEnumerable<AResult>)Manager.Setter.Single(_query.SetNewTest());
        }

        public IEnumerable<AResult> NullifyTests()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyTests());
        }
    }
}