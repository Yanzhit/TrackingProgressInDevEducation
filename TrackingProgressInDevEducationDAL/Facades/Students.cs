using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Requests.Tables;
using Student = TrackingProgressInDevEducationDAL.Models.Bases.Student;
using TrackingProgressInDevEducationDAL.Abstarcts;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Students : AFacade
    {
        public QStudent Query { get; set; }

        /// <summary>
        /// Добавить студента
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="rate">Рейтинг</param>
        /// <param name="groupId">Ид Группы</param>
        /// <param name="phone">Телефон</param>
        /// <param name="email">Эл.почта</param>
        /// <param name="contract">Контракт</param>
        /// <param name="birthday">День рождения</param>
        /// <param name="middleName">Отчество</param>
        /// <param name="git">Гитхаб</param>
        /// <param name="cityId">Ид города</param>
        /// <param name="status">Статус</param>
        /// <returns>Студент</returns>
        public Student SetNewStudent(string name, string surname, decimal rate, int groupId, string phone, string email, string contract, DateTime birthday, string middleName, string git, int cityId, bool status)
        {
            return (Student)_query.QuerySet(_qStudent.SetNewStudent(name, surname, rate, groupId, phone, email, contract, birthday, middleName, git, cityId, status));
        }

        /// <summary>
        /// Получить всех студентов
        /// </summary>
        /// <returns>Студенты</returns>
        public IEnumerable<Student> GetAllStudents()
        {
            return (IEnumerable<Student>)_querySet.QuerySet(Query.GetAllStudents());
        }

        /// <summary>
        /// Обнулить таблицу студентов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> NullifyStudents()
        {
            return (IEnumerable<Student>)_query.QuerySet(_qStudent.NullifyStudents());
        }

    }
}