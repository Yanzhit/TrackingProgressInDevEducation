namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DTStudent
    {
        public int[] TeamId { get; }
        public int[] StudentId { get; }

        public DTStudent()
        {
            TeamId = DataTeamId();
            StudentId = DataStudentId();
        }

        private int[] DataTeamId()
        {
            return new[]
            {
                1, 3, 4
            };
        }
        
        private int[] DataStudentId()
        {
            return new[]
            {
                3, 2, 4
            };
        }
    }
}