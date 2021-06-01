using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DTStudents : ADMock
    {
        public int[] TeamId { get; }
        public int[] StudentId { get; }

        public DTStudents()
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