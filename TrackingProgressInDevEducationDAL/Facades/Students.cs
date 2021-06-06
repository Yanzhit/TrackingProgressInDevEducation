using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Students : AFacade
    {
        private readonly QStudent _query  = new();

        /// <summary>
        /// Добавить студента
        /// </summary>
        /// <param name="student">объект данных</param>
        /// <returns>Студент</returns>
        public Student SetNewStudent(Student student)
        {
            return (Student)Manager.Setter.Single(_query.SetNewStudent(student));
        }

        /// <summary>
        /// Получить всех студентов
        /// </summary>
        /// <returns>Студенты</returns>
        public IEnumerable<Student> GetAllStudents()
        {
            return (IEnumerable<Student>)Manager.Getter.Several(_query.GetAllStudents());
        }

        public IEnumerable<Student> GetAllStudentsByGroup()
        {
            return (IEnumerable<Student>)Manager.Getter.Several(_query.GetAllStudentsByGroup());
        }

        public IEnumerable<Student> UpdStudentToGroup()
        {
            return (IEnumerable<Student>)Manager.Update.Upd(_query.UpdStudentToGroup());
        }

        /// <summary>
        /// Обнулить таблицу студентов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> NullifyStudents()
        {
            return (IEnumerable<Student>)Manager.Remove.Rem(_query.NullifyStudents());
        }

    }
}