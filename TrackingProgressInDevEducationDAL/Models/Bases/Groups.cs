using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
   public class Groups:IModels
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        
    }
}
