using TrackingProgressInDevEducationDAL.Facades;

namespace TrackingProgressInDevEducationDAL
{
    public class FacadeQueries
    {
        /// <summary>
        /// Фасад для городов.
        /// </summary>
        public Cities Cities => new Cities();

        /// <summary>
        /// Фасад для комментариев.
        /// </summary>
        public Comments Comments => new Comments();

        /// <summary>
        /// Фасад для типа комментариев.
        /// </summary>
        public CommentTypes CommentTypes => new CommentTypes();

        /// <summary>
        /// Фасад для курсов.
        /// </summary>
        public Courses Courses => new Courses();

        /// <summary>
        /// Фасад для групп.
        /// </summary>
        public Groups Groups => new Groups();

        /// <summary>
        /// Фасад для выполненного дз.
        /// </summary>
        public HWCompletes HWCompletes => new HWCompletes();

        /// <summary>
        /// Фасад для групповых дз.
        /// </summary>
        public HWGroups HWGroups => new HWGroups();

        /// <summary>
        /// Фасад для дз.
        /// </summary>
        public Homeworks Homeworks => new Homeworks();

        /// <summary>
        /// Фасад для лекций.
        /// </summary>
        public Lections Lections => new Lections();

        /// <summary>
        /// Фасад для связи лектора к курсу.
        /// </summary>
        public LectorCourses LectorCourses => new LectorCourses();

        /// <summary>
        /// Фасад для связи лектора к группе.
        /// </summary>
        public LectorGroups LectorGroups => new LectorGroups();

        /// <summary>
        /// Фасад для лекторов.
        /// </summary>
        public Lectors Lectors => new Lectors();

        /// <summary>
        /// Фасад для оплаты.
        /// </summary>
        public Payments Payments => new Payments();

        /// <summary>
        /// Фасад для студентов.
        /// </summary>
        public Students Students => new Students();

        /// <summary>
        /// Фасад для команд.
        /// </summary>
        public Teams Teams => new Teams();

        /// <summary>
        /// Фасад для команд студентов.
        /// </summary>
        public TeamStudents TeamStudents => new TeamStudents();

        /// <summary>
        /// Фасад для посещения.
        /// </summary>
        public Visits Visits => new Visits();
    }
}
