using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Course : AbstractModel
    {
        public string Name { get; set; }
        public string StartedOn { get; set; }
        public string FinishedOn { get; set; }

        public Course()
        {
        }

        public Course(string name, string startedOn, string finishedOn, int id) : base(id)
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
