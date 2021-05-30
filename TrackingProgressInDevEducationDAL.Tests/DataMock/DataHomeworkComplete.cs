namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataHomeworkComplete
    {
        public int[] HomeworkId { get; }
        public int[] StudentId { get; }
        public bool[] Status { get; }

        public DataHomeworkComplete()
        {
            HomeworkId = DataHomeworkId();
            StudentId = DataStudentId();
            Status = DataStatus();
        }

        private int[] DataHomeworkId()
        {
            return new[]
            {
                3, 2, 1
            };
        }
        private int[] DataStudentId()
        {
            return new[]
            {
                1, 2, 3
            };
        }
        private bool[] DataStatus()
        {
            return new[]
            {
                true,
                false,
                true
            };
        }
    }
}