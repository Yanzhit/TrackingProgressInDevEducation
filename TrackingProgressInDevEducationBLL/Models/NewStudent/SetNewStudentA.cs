using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.NewStudent
{
    public class SetNewStudentA : ADTOAnswer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal? Rate { get; set; }
        public int? GroupId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contract { get; set; }
        public string Birthday { get; set; }
        public string MiddleName { get; set; }
        public string Git { get; set; }
        public int? CityId { get; set; }
        public bool? Status { get; set; }

        public SetNewStudentA()
        {
        }

        public SetNewStudentA
        (
            string name,
            string surname,
            string middleName,
            string phone,
            string birthday,
            decimal? rate = null,
            int? groupId = null,
            string email = null,
            string contract = null,
            string git = null,
            int? cityId = null,
            bool? status = null
        )
        {
            Name = name;
            Surname = surname;
            Rate = rate;
            GroupId = groupId;
            Phone = phone;
            Email = email;
            Contract = contract;
            Birthday = birthday;
            MiddleName = middleName;
            Git = git;
            CityId = cityId;
            Status = status;
        }

        public override bool Equals(object obj)
        {
            return Equals((SetNewStudentA)obj);
        }

        private bool Equals(SetNewStudentA actual)
        {
            return actual != null
                   && Name == actual.Name
                   && Surname == actual.Surname
                   && Rate == actual.Rate
                   && GroupId == actual.GroupId
                   && Phone == actual.Phone
                   && Email == actual.Email
                   && Contract == actual.Contract
                   && Birthday == actual.Birthday
                   && MiddleName == actual.MiddleName
                   && Git == actual.Git
                   && CityId == actual.CityId
                   && Status == actual.Status;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Name);
            hashCode.Add(Surname);
            hashCode.Add(Rate);
            hashCode.Add(GroupId);
            hashCode.Add(Phone);
            hashCode.Add(Email);
            hashCode.Add(Contract);
            hashCode.Add(Birthday);
            hashCode.Add(MiddleName);
            hashCode.Add(Git);
            hashCode.Add(CityId);
            hashCode.Add(Status);
            return hashCode.ToHashCode();
        }
    }
}
