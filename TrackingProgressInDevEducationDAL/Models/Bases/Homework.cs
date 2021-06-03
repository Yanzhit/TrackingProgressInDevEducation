using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Homework : AbstractModel
    {
        public string Name { get; set; }
        public string Deskription { get; set; }

        public Homework()
        {
        }

        public Homework(string name, string deskription)
        {
            Name = name;
            Deskription = deskription;
        }

        public override bool Equals(object obj)
        {
            return Equals((Homework)obj);
        }

        private bool Equals(Homework other)
        {
            return Name == other.Name
                   && Deskription == other.Deskription;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Deskription);
        }
    }
}