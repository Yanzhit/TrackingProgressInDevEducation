namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class City : AbstractModel
    {
        public string Name { get; set; }
        
        public City(string name)
        {
            Name = name;
        }
        public override bool Equals(object obj)
        {
            return Equals((City)obj);
        }

        private bool Equals(City other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}