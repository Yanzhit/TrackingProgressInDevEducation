using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ITestsCompletes
    {
        IEnumerable<TestComplete> SetNewTC();
        IEnumerable<TestComplete> GetTestScore();
        IEnumerable<TestComplete> NullifyTCs();
    }
}