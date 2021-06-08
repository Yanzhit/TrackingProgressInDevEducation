using TrackingProgressInDevEducationBLL.Logics.Answers;
using TrackingProgressInDevEducationBLL.Logics.Queries;

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
        /// Ответы на запросы со страниц SignIns
        /// </summary>
        public SignInsA SignInsA => new();
        /// <summary>
        /// Запрос со страниц Group
        /// </summary>
        public GroupsQ GroupsQ => new();

        /// <summary>
        /// Запрос со страниц Group
        /// </summary>
        public CoursesQ CoursesQ => new();

        /// <summary>
        /// Ответы на запросы со страниц Group
        /// </summary>
        public GroupsA GroupsA => new();

        /// <summary>
        /// Ответы на запросы со страниц Group
        /// </summary>
        public CoursesA CoursesA => new();

        public RegistrationsQ RegistrationsQ => new();
        public RegistrationsA RegistrationsA => new();
        public VerificationsQ VerificationsQ => new();
        public VerificationsA VerificationsA => new();
        public MainPagesA MainPagesA => new();
        public MainPagesQ MainPagesQ => new();
    }
}