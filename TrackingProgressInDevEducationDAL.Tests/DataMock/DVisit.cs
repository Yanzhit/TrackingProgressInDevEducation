namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DVisit
    {
        public bool[] VisitStatus { get; }
        public int[] StudentId { get; }
        public int[] LectionId { get; }

        public DVisit()
        {
            VisitStatus = DataVisitStatus();
            StudentId = DataStudentId();
            LectionId = DataLectionId();
        }

        private bool[] DataVisitStatus()
        {
            return new[]
            {
                true,
                false,
                true
            };
        }
        private int[] DataStudentId()
        {
            return new[]
            {
               1, 2, 3
            };
        }
        private int[] DataLectionId()
        {
            return new[]
            {
                4, 2, 1
            };
        }
    }
}