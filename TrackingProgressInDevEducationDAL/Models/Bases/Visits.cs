using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Visits : IModels
    {
        public bool VisitStatus { get; set; }
        public int StudentId { get; set; }
        public int LectionId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Visits)obj);
        }

        private bool Equals(Visits other)
        {
            return VisitStatus == other.VisitStatus
                   && StudentId == other.StudentId
                   && LectionId == other.LectionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(VisitStatus, StudentId, LectionId);
        }
    }
}
