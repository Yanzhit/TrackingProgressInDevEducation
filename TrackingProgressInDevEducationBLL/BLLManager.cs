using TrackingProgressInDevEducationBLL.Logics.Answers;
using TrackingProgressInDevEducationBLL.Logics.Queries;
using TrackingProgressInDevEducationBLL.Models.Group;

namespace TrackingProgressInDevEducationBLL
{
    /// <summary>
    /// Фасад Блл
    /// </summary>
    public class BLLManager
    {
        /// <summary>
        /// Запрос со страниц SignIns
        /// </summary>
        public SignInsQ SignInsQ => new();
        /// <summary>
        /// Запрос со страниц Курса
        /// </summary>
        public NewCoureQ NewCoureQ => new();
        /// <summary>
        /// Запрос со страниц Курса
        /// </summary>
        public SenNewCourse SenNewCourse => new();

        /// <summary>
        /// Ответы на запросы со страниц SignIns
        /// </summary>
        public SignInsA SignInsA => new();
        /// <summary>
        /// Запрос со страниц Group
        /// </summary>
        public GroupsQ GroupsQ => new();

        /// <summary>
        /// Ответы на запросы со страниц Group
        /// </summary>
        public GroupsA GroupsA => new();

        /// <summary>
        /// Запрос со страниц Group
        /// </summary>
        public CoursesQ CoursesQ => new();

        /// <summary>
        /// Ответы на запросы со страниц Group
        /// </summary>
        public CoursesA CoursesA => new();

        /// <summary>
        /// Запрос со страниц NewStudent
        /// Ответы на запросы со страниц Courses
        /// </summary>
        public SetNewCoursesA SetNewCoursesA => new();
        
        /// <summary>
        /// Ответы на запросы со страниц Group
        /// </summary>
        public NewStudentsQ NewStudentQ => new();

        /// <summary>
        /// Ответы на запросы со страниц NewStudent
        /// </summary>
        public NewStudentsA NewStudentA => new();


        /// <summary>
        /// Запрос со страниц NewStudent
        /// </summary>
        public NewStudentsQ CityQ => new();

        /// <summary>
        /// Ответы на запросы со страниц NewStudent
        /// </summary>
        public NewStudentsA CityA => new();

        public RegistrationsQ RegistrationsQ => new();
        public RegistrationsA RegistrationsA => new();
        public VerificationsQ VerificationsQ => new();
        public VerificationsA VerificationsA => new();
        public MainPagesA MainPagesA => new();
        public MainPagesQ MainPagesQ => new();
    }
}