using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Visits
    {
        public bool VisitStatus { get; set; }
        public int StudentId { get; set; }
        public int LectionId { get; set; }

        //public Visits(Connect connect)
        //{
        //    VisitStatus = true;
        //    StudentId = 0;
        //    LectionId = 0;
        //}
    }
}
