using System.Collections;
using System.Runtime.Intrinsics.X86;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.Expected.Students
{
    public class EStudents : AExpected, IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                Facade.Students.NullifyStudents(),
                Expected = 1
            };
            yield return new object[]
            {
                Facade.Students.NullifyStudents(),
                Expected = 2
            };
            yield return new object[]
            {
                Facade.Students.NullifyStudents(),
                Expected = 3
            };
        }
    }
}