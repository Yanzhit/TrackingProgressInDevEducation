using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.NewStudent
{
    public class SetCityA : ADTOAnswer
    {
        public string Name { get; set; }

        public SetCityA()
        {
        }

        public SetCityA(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            return Equals((SetCityA)obj);
        }

        private bool Equals(SetCityA other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
