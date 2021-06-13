using TrackingProgressInDevEducationBLL.Models.Course;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы Course
    /// </summary>
    public class SenNewCourse : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос создания нового курса
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        public SetNewCoursesA SetNewCourse(TrackingProgressInDevEducationDAL.Models.Bases.Course model)
        {
            WriteTypes(new Courses().SetNewCourse());
            return (SetNewCoursesA)GetModelBaseSingle(model);
        }
    }
}