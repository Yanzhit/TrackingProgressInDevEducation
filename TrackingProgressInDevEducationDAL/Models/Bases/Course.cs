using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Course : AbstractModel
    {
        public string Name { get; }
        public string StartedOn { get; }
        public string FinishedOn { get; }

        public Course()
        {
        }

        public Course(Course course) : base(course)
        {
            Name = course.Name;
            StartedOn = course.StartedOn;
            FinishedOn = course.FinishedOn;
        }
        public Course(object obj) : base(obj)
        {
            var course = (Course)obj;
            Name = course.Name;
            StartedOn = course.StartedOn;
            FinishedOn = course.FinishedOn;
        }
        public override bool Equals(object obj)
        {
            return Equals((Course)obj);
        }

        private bool Equals(Course other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && StartedOn == other.StartedOn
                   && FinishedOn == other.FinishedOn;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            hashCode.Add(StartedOn);
            hashCode.Add(FinishedOn);
            return hashCode.ToHashCode();
        }
    }
}