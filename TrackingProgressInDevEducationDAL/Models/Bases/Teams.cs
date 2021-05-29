namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Teams : AbstractModels
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
