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
        /// Запрос со страниц SignIn
        /// </summary>
        public QSignIns QSignIns => new();

        /// <summary>
        /// Ответы на запросы со страниц SignIn
        /// </summary>
        public ASignIns ASignIns => new();
        /// <summary>
        /// Запрос со страниц Group
        /// </summary>
        public QGroup QGroup => new();

        /// <summary>
        /// Ответы на запросы со страниц Group
        /// </summary>
        public AGroups AGroups => new();
    }
}