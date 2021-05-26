using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class HomeworkGroup : IModels
    {
        public int HomeworkId { get; set; }
        public int GroupId { get; set; }
    }
}
