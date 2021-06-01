using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class Query : IQuery
    {
        public Type Type { get; } = typeof(Student);
        public TypeQueries TypeQueries { get; set; }
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
        public Query SetNewStudent
            (
                string name,
                string surname,
                decimal rate,
                int groupId,
                string phone,
                string email,
                string contract,
                DateTime birthday,
                string middleName,
                string git,
                int cityId,
                bool status
            )
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewStudent);
            Params = $"{name}{Sep}{surname}{Sep}{rate}{Sep}{groupId}{Sep}" +
                     $"{phone}{Sep}{email}{Sep}{contract}{Sep}{birthday}{Sep}" +
                     $"{middleName}{Sep}{git}{Sep}{cityId}{Sep}{status}";
            return this;
        }

        /// <summary>
        /// Получить всех студентов из таблицы
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public Query GetAllStudents()
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(GetAllStudents);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы студентов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public Query NullifyStudents()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyStudents);
            Params = string.Empty;
            return this;
        }

        //public QStudent GetByIdStudent(int id)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetByIdStudent);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}