using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Test : AbstractModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Test()
        {
        }

        public Test(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            return Equals((Test)obj);
        }

        private bool Equals(Test other)
        {
            return Name == other.Name
                   && Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }
    }
}
