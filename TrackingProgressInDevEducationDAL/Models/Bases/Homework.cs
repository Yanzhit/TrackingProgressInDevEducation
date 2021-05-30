namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Homework : AbstractModel
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Homework)obj);
        }

        private bool Equals(Homework other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}