using System;


namespace TrackingProgressInDevEducationBLL.Models.GroupInfo
{
    public class GetAllCoursesByGroupA : ADTOAnswer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GetAllCoursesByGroupA()
        {
        }
        public GetAllCoursesByGroupA(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetAllCoursesByGroupA)obj);
        }

        private bool Equals(GetAllCoursesByGroupA other)
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
