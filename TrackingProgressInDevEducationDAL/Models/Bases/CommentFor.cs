using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class CommentFor : AbstractModel
    {
        public string Name { get; }

        public CommentFor(CommentFor commentFor) : base(commentFor)
        {
            Name = commentFor.Name;
        }
        public override bool Equals(object obj)
        {
            return Equals((CommentFor)obj);
        }

        private bool Equals(CommentFor other)
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