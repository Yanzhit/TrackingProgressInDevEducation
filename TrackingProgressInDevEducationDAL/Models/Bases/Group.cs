using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
   public class Group : AbstractModel
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public Group()
        {
        }

        public Group(string name, int courseId, string startDate, string endDate)
        {
            Name = name;
            CourseId = courseId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((Group)obj);
        }

        private bool Equals(Group other)
        {
            return Name == other.Name
                   && CourseId == other.CourseId
                   && StartDate == other.StartDate
                   && EndDate == other.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, CourseId, StartDate, EndDate);
        }
    }
}
