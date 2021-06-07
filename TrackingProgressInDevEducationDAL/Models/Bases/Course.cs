using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Course : AbstractModel
    {
        public string Name { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime FinishedOn { get; set; }

        public Course()
        {
        }

        public Course(string name, DateTime startedOn, DateTime finishedOn)
        {
            Name = name;
            StartedOn = startedOn;
            FinishedOn = finishedOn;
        }

        public override bool Equals(object obj)
        {
            return Equals((Course)obj);
        }

        private bool Equals(Course other)
        {
            return Name == other.Name
                   && StartedOn == other.StartedOn
                   && FinishedOn == other.FinishedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StartedOn, FinishedOn);
        }
    }
}
