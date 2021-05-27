using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Lectors : IModels
    {
        public int FullName { get; set; }
        public int Email { get; set; }
        public string Password { get; set; }
    }
}
