using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Teams : IModels
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Teams)obj);
        }

        private bool Equals(Teams other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
