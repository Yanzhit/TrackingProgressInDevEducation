using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DLectorGroup : ADMock
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