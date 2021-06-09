using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class CType : AbstractModel
    {
        public string Name { get; }

        public CType()
        {
        }

        public CType(CType cType) : base(cType)
        {
            Name = cType.Name;
        }

        public override bool Equals(object obj)
        {
            return Equals((CType)obj);
        }

        private bool Equals(CType other)
        {
            return Id == other.Id
                   && Name == other.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            return hashCode.ToHashCode();
        }
    }
}