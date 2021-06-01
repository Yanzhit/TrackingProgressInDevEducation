namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class CommentType : AbstractModel
    {
        public string Name { get; set; }

        public CommentType()
        {
        }

        public CommentType(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return Equals((CommentType)obj);
        }

        private bool Equals(CommentType other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}