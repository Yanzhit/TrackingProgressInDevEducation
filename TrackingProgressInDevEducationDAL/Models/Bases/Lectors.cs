using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lectors : IModels
    {
        public int FullName { get; set; }
        public int Email { get; set; }
        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Lectors)obj);
        }

        private bool Equals(Lectors other)
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
