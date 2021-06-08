using System;

namespace TrackingProgressInDevEducationBLL.Models.Registration
{
    public class SetLectorQ : ADTOQuery
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public SetLectorQ()
        {
        }

        public SetLectorQ(string fullName, string email, string password)
        {
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