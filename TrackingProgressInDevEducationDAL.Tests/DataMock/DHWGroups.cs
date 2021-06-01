using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DHWGroups : ADMock
    {
        public int[] HomeworkId { get; }
        public int[] GroupId { get; }

        public DHWGroups()
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