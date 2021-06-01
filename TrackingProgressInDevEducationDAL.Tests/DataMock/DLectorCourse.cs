namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DLectorCourse
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