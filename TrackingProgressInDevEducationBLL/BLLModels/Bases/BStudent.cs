using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BStudent
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal? Rate { get; set; }
        public int? GroupId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contract { get; set; }
        public DateTime? Birthday { get; set; }
        public string MiddleName { get; set; }
        public string Git { get; set; }
        public int? CityId { get; set; }
        public bool? Status { get; set; }

        public BStudent()
        {
        }

        public BStudent(Student student)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, BStudent>());
            Mapper mapper = new Mapper(config);
            BStudent tmpBStudent = mapper.Map<BStudent>(student);

            this.Name = tmpBStudent.Name;
            this.Surname = tmpBStudent.Surname;
            this.Rate = tmpBStudent.Rate;
            this.GroupId = tmpBStudent.GroupId;
            this.Email = tmpBStudent.Email;
            this.Contract = tmpBStudent.Contract;
            this.Birthday = tmpBStudent.Birthday;
            this.MiddleName = tmpBStudent.MiddleName;
            this.Git = tmpBStudent.Git;
            this.CityId = tmpBStudent.CityId;
            this.Status = tmpBStudent.Status;
        }

        public override bool Equals(object obj)
        {
            return Equals((BStudent)obj);
        }

        private bool Equals(BStudent actual)
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
