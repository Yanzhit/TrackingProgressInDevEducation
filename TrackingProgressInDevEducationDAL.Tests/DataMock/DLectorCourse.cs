using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DLectorCourse : ADMock
    {
        public int[] LectorId {get;}
        public int[] CourseId {get;}

        public DLectorCourse()
        {
            LectorId = DataLectorId();
            CourseId = DataCourseId();
        }

        private int[] DataLectorId()
        {
            return new[]
            {
                1, 3, 4
            };
        }

        private int[] DataCourseId()
        {
            return new[]
            {
                3, 2, 4
            };
        }
    }
}