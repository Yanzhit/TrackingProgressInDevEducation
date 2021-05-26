using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lections : IModels
    {
        public int CourseId { get; set; }
        public int LectorId { get; set; }
        public string StartedOn { get; set; }
    }
}
