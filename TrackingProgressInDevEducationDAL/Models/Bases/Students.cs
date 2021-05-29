using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Students : AbstractModels
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Decimal Rate { get; set; }
        
        public override bool Equals(object obj)
        {
            return Equals((Students)obj);
        }

        private bool Equals(Students actual)
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
