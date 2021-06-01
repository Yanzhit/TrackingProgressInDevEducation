using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lector : AbstractModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Lector()
        {
        }

        public Lector(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public override bool Equals(object obj)
        {
            return Equals((Lector)obj);
        }

        private bool Equals(Lector other)
        {
            return FullName == other.FullName
                   && Email == other.Email
                   && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, Email, Password);
        }
    }
}
