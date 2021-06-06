using System;

namespace TrackingProgressInDevEducationBLL.Models.SignIn
{
    /// <summary>
    /// Модель данных для запроса со страницы SignIn(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для запроса из UI в DAL
    /// </summary>
    public class LectorQuery : ADTOQuery
    {
        /// <summary>
        /// Электронная почта 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public LectorQuery()
        {
        }

        /// <summary>
        /// Конструктор для данного запроса
        /// </summary>
        /// <param name="email">Электронная почта </param>
        /// <param name="password">Пароль</param>
        public LectorQuery(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectorQuery)obj);
        }

        private bool Equals(LectorQuery other)
        {
            return Email == other.Email
                   && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Email, Password);
        }

    }
}