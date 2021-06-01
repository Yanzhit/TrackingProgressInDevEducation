using System;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DLection
    {
        public int[] GroupId { get; }
        public int[] LectorId { get; }
        public DateTime[] StartedOn { get; }

        public DLection()
        {
            GroupId = DataGroupId();
            LectorId = DataLectorId();
            StartedOn = DataStartedOn();
        }

        private int[] DataGroupId()
        {
            return new[]
            {
                1, 2, 3, 4, 5
            };
        }

        private int[] DataLectorId()
        {
            return new[]
            {
                1, 2, 3, 4, 5
            };
        }

        private DateTime[] DataStartedOn()
        {
            return new DateTime[]
            {
                DateTime.MaxValue,
                DateTime.MinValue,
                DateTime.Now,
                DateTime.Today,
                DateTime.Now
            };
        }
    }
}