using System;
using System.Net.Mime;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class CommentFor : AbstractModel
    {
        public string Name { get; set; }

        public CommentFor(string name)
        {
            Name = name;
        }
        public override bool Equals(object obj)
        {
            return Equals((CommentFor)obj);
        }

        private bool Equals(CommentFor other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name != null ? Name.GetHashCode() : 0);
        }
    }
}