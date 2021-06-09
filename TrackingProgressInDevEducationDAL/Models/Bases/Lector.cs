using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lector : AbstractModel
    {
        public string Login { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActivated { get; set; }

        public Lector()
        {
        }

        public Lector(string login, string fullName, string email, string password)
        {
            Login = login;
            FullName = fullName;
            Email = email;
            Password = password;
            IsActivated = false;
        }
        public override bool Equals(object obj)
        {
            return Equals((Lector)obj);
        }

        private bool Equals(Lector other)
        {
            return Login == other.Login
                   && FullName == other.FullName
                   && Email == other.Email
                   && Password == other.Password
                   && IsActivated == other.IsActivated;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Login, FullName, Email, Password, IsActivated);
        }
    }
}
