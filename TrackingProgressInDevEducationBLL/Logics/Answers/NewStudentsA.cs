using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Logics.Answers
{
    /// <summary>
    /// Все ответы на запросы от BD для страницы нового студента
    /// </summary>
    public class NewStudentsA : AAnswer
    {
        /// <summary>
        /// Ответ от BD на запрос создания нового студента
        /// </summary>
        /// <param name="model">Входящая модель от DAL для обработки</param>
        /// <returns>Модель ответа с вложенными данными</returns>
        /// 
        public SetNewStudentA SetNewStudent(AbstractModel model)
        {
            WriteTypes(new NewStudents().SetNewStudent());
            return (SetNewStudentA) GetModelBaseSingle(model);
        }

        public IEnumerable<SetCityA> GetAllCities(IEnumerable<AbstractModel> model)
        {
            WriteTypes(new NewStudents().GetAllCities());
            return (IEnumerable<SetCityA>)GetModelBaseSeveral(model);
        }
    }
}
