using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class Test : AbstractModel
    {
        public string Name { get; }
        public string Description { get; }

        public Test()
        {
        }

        public Test(Test test) : base (test)
        {
            Name = test.Name;
            Description = test.Description;
        }

        public override bool Equals(object obj)
        {
            return Equals((Test)obj);
        }

        private bool Equals(Test other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && Description == other.Description;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            hashCode.Add(Description);
            return hashCode.ToHashCode();
        }
    }
}
