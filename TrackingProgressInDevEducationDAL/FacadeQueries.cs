using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Abstarcts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL
{
    public class FacadeQueries
    {
        /// <summary>
        /// Фасад для городов.
        /// </summary>
        public Cities Cities => new Cities
        {
            Query = new QCity()
        };

        /// <summary>
        /// Фасад для комментариев.
        /// </summary>
        public Comments Comments => new Comments
        {
            Query = new QComment()
        };

        /// <summary>
        /// Фасад для типа комментариев.
        /// </summary>
        public CommentTypes CommentTypes => new CommentTypes
        {
            Query = new QCommentType()
        };

        /// <summary>
        /// Фасад для курсов.
        /// </summary>
        public Courses Courses => new Courses
        {
            Query = new QCourse()
        };

        /// <summary>
        /// Фасад для групп.
        /// </summary>
        public Groups Groups => new Groups
        {
            Query = new QGroup()
        };

        /// <summary>
        /// Фасад для выполненного дз.
        /// </summary>
        public HWCompletes HWCompletes => new HWCompletes
        {
            Query = new QHWComplete()
        };

        /// <summary>
        /// Фасад для групповых дз.
        /// </summary>
        public HWGroups HWGroups => new HWGroups
        {
            Query = new QHWGroup()
        };

        /// <summary>
        /// Фасад для дз.
        /// </summary>
        public Homeworks Homeworks => new Homeworks
        {
            Query = new QHomework()
        };

        /// <summary>
        /// Фасад для лекций.
        /// </summary>
        public Lections Lections => new Lections
        {
            Query = new QLection()
        };

        /// <summary>
        /// Фасад для связи лектора к курсу.
        /// </summary>
        public LectorCourses LectorCourses => new LectorCourses
        {
            Query = new QLectorCourse()
        };

        /// <summary>
        /// Фасад для связи лектора к группе.
        /// </summary>
        public LectorGroups LectorGroups => new LectorGroups
        {
            Query = new QLectorGroup()
        };

        /// <summary>
        /// Фасад для лекторов.
        /// </summary>
        public Lectors Lectors => new Lectors
        {
            Query = new QLector()
        };

        /// <summary>
        /// Фасад для оплаты.
        /// </summary>
        public Payments Payments => new Payments
        {
            Query = new QPayment()
        };

        /// <summary>
        /// Фасад для студентов.
        /// </summary>
        public Students Students => new Students
        {
            Query = new Query()
        };

        /// <summary>
        /// Фасад для команд.
        /// </summary>
        public Teams Teams => new Teams
        {
            Query = new QTeam()
        };

        /// <summary>
        /// Фасад для команд студентов.
        /// </summary>
        public TeamStudents TeamStudents => new TeamStudents
        {
            Query = new QTeamStudent()
        };

        /// <summary>
        /// Фасад для посещения.
        /// </summary>
        public Visits Visits => new Visits
        {
            Query = new QVisit()
        };
    }
}
