using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
   public class Group : AbstractModel
    {
        public string Name { get; set; }
        public int CourseId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Group)obj);
        }

        private bool Equals(Group other)
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
