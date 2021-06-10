using System.Collections;
using System.Collections.Generic;
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
        /// <param name="model">Модель с данными для запроса</param>
        /// <returns>Абстрактную модель данных после ответа от сервера</returns>
        public AbstractModel GetAllCourses(SetCoursesQ model)
        {
            WriteTypes(new Courses().GetAllCourses());
            return GetModelBaseSingle(model);
        }
    }
}
