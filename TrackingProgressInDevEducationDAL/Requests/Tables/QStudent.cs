﻿using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QStudent : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Student);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового студента
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="rate">Рейтинг студента</param>
        /// <param name="groupId">id группы студента</param>
        /// <param name="phone">Контактный телефон студента</param>
        /// <param name="email">Контактная электронная почта студента</param>
        /// <param name="contract">№ контракта студента</param>
        /// <param name="birthday">День рождения студента</param>
        /// <param name="middleName">Отчество студента</param>
        /// <param name="git">Ссылка на Git аккаунт студента </param>
        /// <param name="cityId">id города студента</param>
        /// <param name="status">Статус студента, обучается/выпустился (0;1)</param>
        /// <returns>Подготовленный запрос</returns>
        public QStudent SetNewStudent
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
            QueryType = typeof(Setter);
            Name = nameof(SetNewStudent);
            Params = $"{SepStr}{name}{SepMid}{surname}{SepMid}{rate}{SepMid}{groupId}{SepMid}" +
                     $"{phone}{SepMid}{email}{SepMid}{contract}{SepMid}{birthday}{SepMid}" +
                     $"{middleName}{SepMid}{git}{SepMid}{cityId}{SepMid}{status}{SepEnd}";
            return this;
        }

        /// <summary>
        /// Получить всех студентов из таблицы
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QStudent GetAllStudents()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudents);
            Params = string.Empty;
            return this;
        }

        public QStudent GetAllStudentsByGroup()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudentsByGroup);
            Params = string.Empty;
            return this;
        }

        public QStudent UpdStudentToGroup()
        {
            QueryType = typeof(Update);
            Name = nameof(UpdStudentToGroup);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы студентов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QStudent NullifyStudents()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyStudents);
            Params = string.Empty;
            return this;
        }

        //public QStudent GetByIdStudent(int id)
        //{
        //    Name = nameof(GetByIdStudent);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}