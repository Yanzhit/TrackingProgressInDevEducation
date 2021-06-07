using System;

namespace TrackingProgressInDevEducationBLL.Models.Registration
{
    public class ANewLector : ADTOAnswer
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ANewLector()
        {
        }

        public ANewLector(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public override bool Equals(object obj)
        {
            return Equals((ANewLector)obj);
        }

        private bool Equals(ANewLector other)
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