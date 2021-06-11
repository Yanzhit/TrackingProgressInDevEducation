using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
   public class Group : AbstractModel
    {
        public string Name  { get; set; }
        public int CourseId  { get; set; }
        public string StartDate  { get; set; }
        public string EndDate  { get; set; }

        public Group()
        {
        }

        public Group(Group group) : base(group)
        {
            Name = group.Name;
            CourseId = group.CourseId;
            StartDate = group.StartDate;
            EndDate = group.EndDate;
        }
        public Group(object obj) : base(obj)
        {
            var group = (Group) obj;
            Name = group.Name;
            CourseId = group.CourseId;
            StartDate = group.StartDate;
            EndDate = group.EndDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((Group)obj);
        }

        private bool Equals(Group other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && CourseId == other.CourseId
                   && StartDate == other.StartDate
                   && EndDate == other.EndDate;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            hashCode.Add(CourseId);
            hashCode.Add(StartDate);
            hashCode.Add(EndDate);
            return hashCode.ToHashCode();
        }
    }
}