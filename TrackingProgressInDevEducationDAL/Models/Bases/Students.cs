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

        public override bool Equals(object obj)
        {
            Students actual = (Students)obj;
            Students expected = this;
            if (actual != null)
            {
                if (expected.Name != actual.Name)
                {
                    return false;
                }
                if (expected.Surname != actual.Surname)
                {
                    return false;
                }
                if (expected.Rate != actual.Rate)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        //public override string ToString()
        //{
        //    return "";
        //}

    }
}
