using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models.Students;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationBLL.Transfers;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы студентов
    /// </summary>
    public class StudentsSA : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос получения всех студентов
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        public IEnumerable<GetAllStudentsA> GetAllStudents(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new StudentsS().GetAllStudents());
            return (IEnumerable<GetAllStudentsA>)GetModelBaseSeveral(model);
        }
    }
}