using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class City : AbstractModel
    {
        public string Name { get; set; }
        
        public City()
        {
        }

        public City(City city) : base(city)
        {
            Name = city.Name;
        }
        public City(object obj) : base(obj)
        {
            var city = (City) obj;
            Name = city.Name;
        }

        public override bool Equals(object obj)
        {
            return Equals((City)obj);
        }

        private bool Equals(City other)
        {
            return Id == other.Id 
                && Name == other.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            return hashCode.ToHashCode();
        }
    }
}