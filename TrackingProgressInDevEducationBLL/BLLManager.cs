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
        public MainPagesQ MainPagesQ => new();
        public MainPagesA MainPagesA => new();
        public AddStudentsToGroupsQ AddStudentsToGroupsQ => new();
        public AddStudentsToGroupsA AddStudentsToGroupsA => new();
        public AddStudentsToTeamsQ AddStudentsToTeamsQ => new();
        public AddStudentsToTeamsA AddStudentsToTeamsA => new();
        public CitiesQ CitiesQ => new();
        public CitiesA CitiesA => new();
        public CreateTeamsQ CreateTeamsQ => new();
        public CreateTeamsA CreateTeamsA => new();
        public GroupInfosQ GroupInfosQ => new();
        public GroupInfosA GroupInfosA => new();
        public GroupJournalsQ GroupJournalsQ => new();
        public GroupJournalsA GroupJournalsA => new();
        public MyProfilesQ MyProfilesQ => new();
        public MyProfilesA MyProfilesA => new();
        public StudentProfilesQ StudentProfilesQ => new();
        public StudentProfilesA StudentProfilesA => new();
        public StudentRatesQ StudentRatesQ => new();
        public StudentRatesA StudentRatesA => new();
        public StudentsSQ StudentsSQ => new();
        public StudentsSA StudentsSA => new();
        public TeamInfosQ TeamInfosQ => new();
        public TeamInfosA TeamInfosA => new();
        public TeamRatesQ TeamRatesQ => new();
        public TeamRatesA TeamRatesA => new();
    }
}