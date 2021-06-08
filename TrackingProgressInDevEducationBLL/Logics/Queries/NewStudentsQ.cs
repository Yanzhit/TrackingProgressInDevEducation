using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    /// <summary>
    /// Создать новую группу
    /// </summary>
    /// <param name="setGroupQ">Модель с данными для запроса</param>
    /// <returns>Абстрактную модель данных после ответа от сервера</returns>
    public class NewStudentsQ : AQuery
    {
        public AbstractModel SetNewStudent(SetNewStudentQ setNewStudentQ)
        {
            WriteTypes(new StudentsS().SetNewStudent());
            return GetModelBaseSingle(setNewStudentQ);
        }
    }
}
