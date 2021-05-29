namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class CommentType : AbstractModels
    {
        public string Name { get; set; }

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