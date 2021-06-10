using System;

namespace TrackingProgressInDevEducationDAL.Models.Others
{
    public class GetAllStudentsByGroup : AbstractModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Git { get; set; }
        public string Rate { get; set; }
        public GetAllStudentsByGroup()
        {
        }

        public GetAllStudentsByGroup(GetAllStudentsByGroup group) : base(group)
        {
            Name = group.Name;
            Surname = group.Surname;
            Git = group.Git;
            Rate = group.Rate;
           
        }
        public GetAllStudentsByGroup(object obj) : base(obj)
        {
            var group = (GetAllStudentsByGroup)obj;
            Name = group.Name;
            Surname = group.Surname;
            Git = group.Git;
            Rate = group.Rate;
        }
        public override bool Equals(object obj)
        {
            return Equals((GetAllStudentsByGroup)obj);
        }

        private bool Equals(GetAllStudentsByGroup other)
        {
            return Id == other.Id
            && Name == other.Name
            && Surname == other.Surname
            && Git == other.Git
            && Rate == other.Rate;     
            }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
