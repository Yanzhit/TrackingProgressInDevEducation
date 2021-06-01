namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class CType : AbstractModel
    {
        public string Name { get; set; }

        public CType()
        {
        }

        public CType(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return Equals((CType)obj);
        }

        private bool Equals(CType other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}