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

        public Visits(List<object> objects)
        {
            VisitStatus = (bool) objects[1];
            StudentId = (int) objects[2];
            LectionId = (int) objects[3];
        }
    }
}
