using System;

namespace TrackingProgressInDevEducationBLL.Models.SignIn
{
    public class LectorQuery : ADTOQuery
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LectorQuery()
        {
        }

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