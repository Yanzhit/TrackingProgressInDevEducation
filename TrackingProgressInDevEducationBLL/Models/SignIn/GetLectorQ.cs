using System;

namespace TrackingProgressInDevEducationBLL.Models.SignIn
{
    /// <summary>
    /// Модель данных для запроса со страницы SignIns(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для запроса из UI в DAL
    /// </summary>
    public class GetLectorQ : ADTOQuery
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
        public GetLectorQ()
        {
        }

        /// <summary>
        /// Конструктор для данного запроса
        /// </summary>
        /// <param name="email">Электронная почта </param>
        /// <param name="password">Пароль</param>
        public GetLectorQ(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetLectorQ)obj);
        }

        private bool Equals(GetLectorQ other)
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