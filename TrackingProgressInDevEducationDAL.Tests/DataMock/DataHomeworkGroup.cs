namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataHomeworkGroup
    {
        public int[] HomeworkId { get; }
        public int[] GroupId { get; }

        public DataHomeworkGroup()
        {
            HomeworkId = DataHomeworkId();
            GroupId = DataGroupId();
        }

        private int[] DataHomeworkId()
        {
            return new[]
            {
                1, 3, 2
            };
        }
        private int[] DataGroupId()
        {
            return new[]
            {
                3, 2, 1
            };
        }
    }
}