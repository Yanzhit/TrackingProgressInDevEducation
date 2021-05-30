namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Team : AbstractModel
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Team)obj);
        }

        private bool Equals(Team other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
