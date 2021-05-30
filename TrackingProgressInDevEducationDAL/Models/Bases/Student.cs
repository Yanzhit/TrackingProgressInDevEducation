using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Student : AbstractModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Decimal Rate { get; set; }
        public int GroupId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contract { get; set; }
        public DateTime Birthday { get; set; }
        public string MiddleName { get; set; }
        public string Git { get; set; }
        public int CityId { get; set; }

       
        public override bool Equals(object obj)
        {
            return Equals((Student)obj);
        }

        private bool Equals(Student actual)
        {
            return actual != null
                   && Name == actual.Name
                   && Surname == actual.Surname
                   && Rate == actual.Rate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, Rate);
        }
    }
}
