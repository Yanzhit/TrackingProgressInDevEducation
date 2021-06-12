using System;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class GetAllCoursesByGroup : AbstractModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GetAllCoursesByGroup()
        {
        }
        public GetAllCoursesByGroup(GetAllCoursesByGroup courses) : base(courses)
        {
            Name = courses.Name;
            Description = courses.Description;
        }
        public GetAllCoursesByGroup(object obj) : base(obj)
        {
            var group = (GetAllCoursesByGroup)obj;
            Name = group.Name;
            Description = group.Description;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetAllCoursesByGroup)obj);
        }

        private bool Equals(GetAllCoursesByGroup other)
        {
            return Id == other.Id
            && Name == other.Name
            && Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
