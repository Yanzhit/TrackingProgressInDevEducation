namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DLectorGroup
    {
        public int[] LectorId {get;}
        public int[] GroupId {get;}

        public DLectorGroup()
        {
            LectorId = DataLectorId();
            GroupId = DataGroupId();
        }

        private int[] DataLectorId()
        {
            return new[]
            {
                1, 3, 4
            };
        }

        private int[] DataGroupId()
        {
            return new[]
            {
                3, 2, 4
            };
        }
    }
}