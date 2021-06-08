using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Transfers;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы Group
    /// </summary>
    public class NewStudentsA : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос создания новой группы
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        /// 
        public SetNewStudentA SetNewStudent(TrackingProgressInDevEducationDAL.Models.Bases.Student model)
        {
            WriteTypes(new StudentsS().SetNewStudent());
            return (SetNewStudentA) GetModelBaseSingle(model);
        }
}
}
