using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.NewStudent
{
    public class GetCityA : ADTOAnswer
    {
        public string Name { get; set; }

        public GetCityA()
        {
        }

        public GetCityA(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetCityA)obj);
        }

        private bool Equals(GetCityA other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}