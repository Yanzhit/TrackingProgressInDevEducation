using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Students : IModels
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Decimal Rate { get; set; }

        public Students(List<object> objects)
        {
            Name = (string)objects[1];
            Surname = (string)objects[2];
            Rate = (decimal)objects[3];
        }
        public Students()
        {
            Name = "";
            Surname = "";
            Rate = 0;
        }
    }
}
