using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Homeworks : IModels
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((Homeworks)obj);
        }

        private bool Equals(Homeworks other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}