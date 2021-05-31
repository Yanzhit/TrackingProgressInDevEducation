using TrackingProgressInDevEducationBLL.Facades.ForTables;

namespace TrackingProgressInDevEducationBLL.Facades
{
    public class Facade
    {
        /// <summary>
        /// Фасад для городов.
        /// </summary>
        public FacadeCities Cities => new FacadeCities();

        /// <summary>
        /// Фасад для комментрариев.
        /// </summary>
        public FacadeComments Comments => new FacadeComments();

        /// <summary>
        /// Фасад для типа комментариев.
        /// </summary>
        public FacadeCommentType CommentType => new FacadeCommentType();

        /// <summary>
        /// Фасад для курсов.
        /// </summary>
        public FacadeCourses Courses => new FacadeCourses();

        /// <summary>
        /// Фасад для групп.
        /// </summary>
        public FacadeGroups Groups => new FacadeGroups();

        /// <summary>
        /// Фасад для выполненого дз.
        /// </summary>
        public FacadeHomeworkComplete HomeworkComplete => new FacadeHomeworkComplete();

        /// <summary>
        /// Фасад для групповых дз.
        /// </summary>
        public FacadeHomeworkGroup HomeworkGroup => new FacadeHomeworkGroup();

        /// <summary>
        /// Фасад для дз.
        /// </summary>
        public FacadeHomeworks Homeworks => new FacadeHomeworks();

        /// <summary>
        /// Фасад для лекций.
        /// </summary>
        public FacadeLections Lections => new FacadeLections();

        /// <summary>
        /// Фасад для LectorCourses.
        /// </summary>
        public FacadeLectorCourses LectorCourses => new FacadeLectorCourses();

        /// <summary>
        /// Фасад для LectorGroup.
        /// </summary>
        public FacadeLectorGroup LectorGroup => new FacadeLectorGroup();

        /// <summary>
        /// Фасад для лекторов.
        /// </summary>
        public FacadeLectors Lectors => new FacadeLectors();

        /// <summary>
        /// Фасад для оплаты.
        /// </summary>
        public FacadePayments Payments => new FacadePayments();

        /// <summary>
        /// Фасад для студентов.
        /// </summary>
        public FacadeStudent Student => new FacadeStudent();

        /// <summary>
        /// Фасад для комманд.
        /// </summary>
        public FacadeTeams Teams => new FacadeTeams();

        /// <summary>
        /// Фасад для комманд студентов.
        /// </summary>
        public FacadeTeamStudent TeamStudent => new FacadeTeamStudent();

        /// <summary>
        /// Фасад для посещения.
        /// </summary>
        public FacadeVisits Visits => new FacadeVisits();
    }
}
