using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.Group;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы Group
    /// </summary>
    public class CoursesA : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос показать все курсы
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        public IEnumerable<SetCoursesA> GetSetCourses(IEnumerable<Course> model)
        {
            WriteTypes(new Courses().GetAllCourses());
            return (IEnumerable<SetCoursesA>)GetModelBaseSeveral(model);
        }
    }
}