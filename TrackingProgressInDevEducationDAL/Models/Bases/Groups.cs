using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
   public class Groups : AbstrackModels
    {
        public string Name { get; set; }
        public int CourseId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Groups)obj);
        }

        private bool Equals(Groups other)
        {
            return Name == other.Name
                   && CourseId == other.CourseId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, CourseId);
        }
    }
}
