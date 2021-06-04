using TrackingProgressInDevEducationDAL.Facades;

namespace TrackingProgressInDevEducationDAL
{
    public class FacadeManager
    {
        /// <summary>
        /// Фасад для городов.
        /// </summary>
        public Cities Cities => new();

        /// <summary>
        /// Фасад для комментариев.
        /// </summary>
        public Comments Comments => new();

        /// <summary>
        /// Фасад для типа комментариев.
        /// </summary>
        public CommentTypes CTypes => new();

        /// <summary>
        /// Фасад для курсов.
        /// </summary>
        public Courses Courses => new();

        /// <summary>
        /// Фасад для групп.
        /// </summary>
        public Groups Groups => new();

        /// <summary>
        /// Фасад для выполненного дз.
        /// </summary>
        public HWCompletes HWCompletes => new();

        /// <summary>
        /// Фасад для групповых дз.
        /// </summary>
        public HWGroups HWGroups => new();

        /// <summary>
        /// Фасад для дз.
        /// </summary>
        public Homeworks Homeworks => new();

        /// <summary>
        /// Фасад для лекций.
        /// </summary>
        public Lections Lections => new();

        /// <summary>
        /// Фасад для связи лектора к курсу.
        /// </summary>
        public LectorCourses LectorCourses => new();

        /// <summary>
        /// Фасад для связи лектора к группе.
        /// </summary>
        public LectorGroups LectorGroups => new();

        /// <summary>
        /// Фасад для лекторов.
        /// </summary>
        public Lectors Lectors => new();

        /// <summary>
        /// Фасад для оплаты.
        /// </summary>
        public Payments Payments => new();

        /// <summary>
        /// Фасад для студентов.
        /// </summary>
        public Students Students => new();

        /// <summary>
        /// Фасад для команд.
        /// </summary>
        public Teams Teams => new();

        /// <summary>
        /// Фасад для команд студентов.
        /// </summary>
        public TStudents TStudents => new();

        /// <summary>
        /// Фасад для посещения.
        /// </summary>
        public Visits Visits => new();

        public Tests Tests => new();
        public TestsCompletes TestsCompletes => new ();
        public CommentsFor CommentsFor => new ();
    }
}
