using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ITests
    {
        IEnumerable<Test> SetNewTest();
        IEnumerable<Test> NullifyTests();
    }
}