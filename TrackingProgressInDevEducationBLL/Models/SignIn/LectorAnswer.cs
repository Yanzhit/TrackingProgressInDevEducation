﻿using System;

namespace TrackingProgressInDevEducationBLL.Models.SignIn
{
    /// <summary>
    /// Модель данных для ответа на запрос со страницы SignIn(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для ответа из DAL в UI
    /// </summary>
    public class LectorAnswer : ADTOAnswer
    {
        /// <summary>
        /// Проверка на активность аккаунта
        /// </summary>
        public bool IsActivated { get; set; }
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public LectorAnswer()
        {
        }

        /// <summary>
        /// Конструктор для подготовки ответа
        /// </summary>
        /// <param name="id">Идентификатор объекта</param>
        /// <param name="isActivated">Параметр проверки на активацию аккаунта</param>
        public LectorAnswer(int id, bool isActivated)
        {
            Id = id;
            IsActivated = isActivated;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectorAnswer)obj);
        }

        private bool Equals(LectorAnswer other)
        {
            return Id == other.Id
                && IsActivated == other.IsActivated;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IsActivated);
        }

    }
}