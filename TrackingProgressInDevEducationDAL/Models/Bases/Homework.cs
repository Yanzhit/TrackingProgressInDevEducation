using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Homework : AbstractModel
    {
        public string Name { get; }
        public string Deskription { get; }

        public Homework()
        {
        }

        public Homework(Homework homework) : base(homework)
        {
            Name = homework.Name;
            Deskription = homework.Deskription;
        }

        public override bool Equals(object obj)
        {
            return Equals((Homework)obj);
        }

        private bool Equals(Homework other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && Deskription == other.Deskription;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            hashCode.Add(Deskription);
            return hashCode.ToHashCode();
        }
    }
}