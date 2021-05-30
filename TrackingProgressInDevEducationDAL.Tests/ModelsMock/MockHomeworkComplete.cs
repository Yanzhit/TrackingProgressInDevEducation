using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Tests.ModelsMock
{
    public class MockHomeworkComplete : HomeworkComplete
    {
        public MockHomeworkComplete(int homeworkId, int studentId, int status)
        {
            HomeworkId = homeworkId;
            StudentId = studentId;
            Status = status;
        }
    }
}