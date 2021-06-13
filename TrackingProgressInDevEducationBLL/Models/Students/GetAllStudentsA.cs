using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Students
{
    public class GetAllStudentsA : ADTOAnswer
    {
        public string NameS { get; set; }
        public string NameG { get; set; }
        public string NameC { get; set; }
        public string NameCr { get; set; }
        public string Surname { get; set; }
        public int? Rate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contract { get; set; }
        public string Birthday { get; set; }
        public string MiddleName { get; set; }
        public string Git { get; set; }
        public bool? Status { get; set; }

        public GetAllStudentsA()
        {
        }

        public GetAllStudentsA(GetAllStudentsA student)
        {
            NameS = student.NameS;
            NameG = student.NameG;
            NameC = student.NameC;
            NameCr = student.NameCr;
            Surname = student.Surname;
            Rate = student.Rate;
            Phone = student.Phone;
            Email = student.Email;
            Contract = student.Contract;
            Birthday = student.Birthday;
            MiddleName = student.MiddleName;
            Git = student.Git;
            Status = student.Status;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetAllStudentsA)obj);
        }

        private bool Equals(GetAllStudentsA actual)
        {
            return actual != null
                   && Id == actual.Id
                   && NameS == actual.NameS
                   && NameG == actual.NameG
                   && NameC == actual.NameC
                   && NameCr == actual.NameCr
                   && Surname == actual.Surname
                   && Rate == actual.Rate
                   && Phone == actual.Phone
                   && Email == actual.Email
                   && Contract == actual.Contract
                   && Birthday == actual.Birthday
                   && MiddleName == actual.MiddleName
                   && Git == actual.Git
                   && Status == actual.Status;
        }


        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(NameS);
            hashCode.Add(NameG);
            hashCode.Add(NameC);
            hashCode.Add(NameCr);
            hashCode.Add(Surname);
            hashCode.Add(Rate);
            hashCode.Add(Phone);
            hashCode.Add(Email);
            hashCode.Add(Contract);
            hashCode.Add(Birthday);
            hashCode.Add(MiddleName);
            hashCode.Add(Git);
            hashCode.Add(Status);
            return hashCode.ToHashCode();
        }
    }
}
