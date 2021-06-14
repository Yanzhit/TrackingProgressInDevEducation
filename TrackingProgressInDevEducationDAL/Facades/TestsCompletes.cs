using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class TestsCompletes : AFacade, ITestsCompletes
    {
        private readonly QTestComplete _query = new();
        
        public IEnumerable<TestComplete> SetNewTC()
        {
            return (IEnumerable<TestComplete>)Manager.Setter.Single(_query.SetNewTC());
        }

        public IEnumerable<TestComplete> GetTestScore()
        {
            return (IEnumerable<TestComplete>)Manager.Getter.Single(_query.GetTestScore());
        }

        public IEnumerable<TestComplete> NullifyTCs()
        {
            return (IEnumerable<TestComplete>)Manager.Remove.Rem(_query.NullifyTCs());
        }
        
    }
}