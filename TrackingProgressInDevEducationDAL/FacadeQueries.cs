using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL
{
    public class FacadeQueries
    {
        /// <summary>
        /// Фасад для городов.
        /// </summary>
        public Cities Cities => new()
        {
            Query = new QCity()
        };

        /// <summary>
        /// Фасад для комментариев.
        /// </summary>
        public Comments Comments => new()
        {
            Query = new QComment()
        };

        /// <summary>
        /// Фасад для типа комментариев.
        /// </summary>
        public CommentTypes CommentTypes => new()
        {
            Query = new QCommentType()
        };

        /// <summary>
        /// Фасад для курсов.
        /// </summary>
        public Courses Courses => new()
        {
            Query = new QCourse()
        };

        /// <summary>
        /// Фасад для групп.
        /// </summary>
        public Groups Groups => new()
        {
            Query = new QGroup()
        };

        /// <summary>
        /// Фасад для выполненного дз.
        /// </summary>
        public HWCompletes HWCompletes => new()
        {
            Query = new QHWComplete()
        };

        /// <summary>
        /// Фасад для групповых дз.
        /// </summary>
        public HWGroups HWGroups => new()
        {
            Query = new QHWGroup()
        };

        /// <summary>
        /// Фасад для дз.
        /// </summary>
        public Homeworks Homeworks => new()
        {
            Query = new QHomework()
        };

        /// <summary>
        /// Фасад для лекций.
        /// </summary>
        public Lections Lections => new()
        {
            Query = new QLection()
        };

        /// <summary>
        /// Фасад для связи лектора к курсу.
        /// </summary>
        public LectorCourses LectorCourses => new()
        {
            Query = new QLectorCourse()
        };

        /// <summary>
        /// Фасад для связи лектора к группе.
        /// </summary>
        public LectorGroups LectorGroups => new()
        {
            Query = new QLectorGroup()
        };

        /// <summary>
        /// Фасад для лекторов.
        /// </summary>
        public Lectors Lectors => new()
        {
            Query = new QLector()
        };

        /// <summary>
        /// Фасад для оплаты.
        /// </summary>
        public Payments Payments => new()
        {
            Query = new QPayment()
        };

        /// <summary>
        /// Фасад для студентов.
        /// </summary>
        public Students Students => new()
        {
            Query = new QStudent()
        };

        /// <summary>
        /// Фасад для команд.
        /// </summary>
        public Teams Teams => new()
        {
            Query = new QTeam()
        };

        /// <summary>
        /// Фасад для команд студентов.
        /// </summary>
        public TeamStudents TeamStudents => new()
        {
            Query = new QTeamStudent()
        };

        /// <summary>
        /// Фасад для посещения.
        /// </summary>
        public Visits Visits => new()
        {
            Query = new QVisit()
        };
    }
}
