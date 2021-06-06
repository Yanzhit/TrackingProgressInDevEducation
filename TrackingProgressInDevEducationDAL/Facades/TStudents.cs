using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class TStudents : AFacade
    {
        private readonly QTStudent _query  = new();

        /// <summary>
        /// Добавить новую Команду к студентам
        /// </summary>
        /// <param name="tStudent">Объект данных</param>
        /// <returns></returns>
        public AResult SetNewTStudent(TStudent tStudent)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewTStudent(tStudent));
        }

        public IEnumerable<QTStudent> GetAllStudents()
        {
            return (IEnumerable<QTStudent>)Manager.Getter.Several(_query.GetAllStudents());
        }
        public IEnumerable<QTStudent> GetAllStudentsByGroup()
        {
            return (IEnumerable<QTStudent>)Manager.Getter.Several(_query.GetAllStudentsByGroup());
        }
        public IEnumerable<AResult> UpdStudentToGroup()
        {
            return (IEnumerable<AResult>)Manager.Update.Upd(_query.UpdStudentToGroup());
        }
        /// <summary>
        /// Обнуление таблицы Команда Студенты
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyTStudent()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyTStudent());
        }
    }
}