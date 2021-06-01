namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataHWGroup
    {
        public int[] HomeworkId { get; }
        public int[] GroupId { get; }

        public DataHWGroup()
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