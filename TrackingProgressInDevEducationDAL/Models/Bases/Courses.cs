using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Courses : IModels
    {
        public string Name { get; set; }
        public string StartedOn { get; set; }
        public string FinishedOn { get; set; }
        
        public override bool Equals(object obj)
        {
            return Equals((Courses)obj);
        }

        private bool Equals(Courses other)
        {
            return Name == other.Name &&
                   StartedOn == other.StartedOn &&
                   FinishedOn == other.FinishedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StartedOn, FinishedOn);
        }
    }
}
