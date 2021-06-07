using System;

namespace TrackingProgressInDevEducationBLL.Models.Registration
{
    public class QNewLector : ADTOQuery
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public QNewLector()
        {
        }

        public QNewLector(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public override bool Equals(object obj)
        {
            return Equals((QNewLector)obj);
        }

        private bool Equals(QNewLector other)
        {
            return  FullName == other.FullName 
                    && Email == other.Email
                    && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, Email, Password);
        }
    }
}