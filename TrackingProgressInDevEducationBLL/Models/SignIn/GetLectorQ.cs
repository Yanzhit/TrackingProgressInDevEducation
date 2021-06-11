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
        public string Login { get; set; }

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
        /// <param name="login">Электронная почта </param>
        /// <param name="password">Пароль</param>
        public GetLectorQ(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetLectorQ)obj);
        }

        private bool Equals(GetLectorQ other)
        {
            return Login == other.Login
                   && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Login, Password);
        }
    }
}