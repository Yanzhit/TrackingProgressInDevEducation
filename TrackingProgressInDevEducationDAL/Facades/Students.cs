﻿using System;
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
        public AResult SetNewStudent
        (
            string name,
            string surname,
            decimal? rate,
            int? groupId,
            string phone,
            string email,
            string contract,
            DateTime? birthday,
            string middleName,
            string git,
            int? cityId,
            bool? status
        )
        {
            return (AResult)Manager.Setter.Single(_query.SetNewStudent
                (
                    name,
                    surname,
                    rate,
                    groupId,
                    phone,
                    email,
                    contract,
                    birthday,
                    middleName,
                    git,
                    cityId,
                    status
                )
            );
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
        public IEnumerable<AResult> NullifyStudents()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyStudents());
        }

    }
}