using System;

namespace TrackingProgressInDevEducationBLL.Models.Registration
{
    public class SetLectorQ : ADTOQuery
    {
        public string Login { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public SetLectorQ()
        {
        }

        public SetLectorQ(string login, string fullName, string email, string password)
        {
            Login = login;
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public override bool Equals(object obj)
        {
            return Equals((SetLectorQ)obj);
        }

        private bool Equals(SetLectorQ other)
        {
            return  Login == other.Login
                    && FullName == other.FullName 
                    && Email == other.Email
                    && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Login, FullName, Email, Password);
        }
    }
}