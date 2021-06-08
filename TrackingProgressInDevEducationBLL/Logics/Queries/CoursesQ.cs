using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;


namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    public class CoursesQ : AQuery
    {
        /// <summary>
        /// Показать все курсы
        /// </summary>
        /// <param name="setGroupQ">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel GetAllCourses(SetCoursesQ setCoursesQ)
        {
            WriteTypes(new Courses().GetAllCourses());
            return GetModelBaseSeveral(setCoursesQ);
        }
    }
}
