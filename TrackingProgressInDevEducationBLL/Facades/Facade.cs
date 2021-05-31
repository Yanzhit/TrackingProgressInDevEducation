using TrackingProgressInDevEducationBLL.Facades.ForTables;

namespace TrackingProgressInDevEducationBLL.Facades
{
    public class Facade
    {
        public FacadeCities Cities => new FacadeCities();

        public FacadeComments Comments => new FacadeComments();

        public FacadeCommentType CommentType => new FacadeCommentType();

        public FacadeCourses Courses => new FacadeCourses();

        public FacadeGroups Groups => new FacadeGroups();

        public FacadeHomeworkComplete HomeworkComplete => new FacadeHomeworkComplete();

        public FacadeHomeworkGroup HomeworkGroup => new FacadeHomeworkGroup();

        public FacadeHomeworks Homeworks => new FacadeHomeworks();

        public FacadeLections Lections => new FacadeLections();

        public FacadeLectorCourses LectorCourses => new FacadeLectorCourses();

        public FacadeLectorGroup LectorGroup => new FacadeLectorGroup();

        public FacadeLectors Lectors => new FacadeLectors();

        public FacadePayments Payments => new FacadePayments();

        public FacadeStudent Student => new FacadeStudent();

        public FacadeTeams Teams => new FacadeTeams();

        public FacadeTeamStudent TeamStudent => new FacadeTeamStudent();

        public FacadeVisits Visits => new FacadeVisits();
    }
}
