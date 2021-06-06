using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class StudentDTO : ADTOAnswer
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

        public StudentDTO()
        {
        }

        public StudentDTO(Student student)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            StudentDTO tmpStudentDTO = mapper.Map<StudentDTO>(student);

            this.Name = tmpStudentDTO.Name;
            this.Surname = tmpStudentDTO.Surname;
            this.Rate = tmpStudentDTO.Rate;
            this.GroupId = tmpStudentDTO.GroupId;
            this.Email = tmpStudentDTO.Email;
            this.Contract = tmpStudentDTO.Contract;
            this.Birthday = tmpStudentDTO.Birthday;
            this.MiddleName = tmpStudentDTO.MiddleName;
            this.Git = tmpStudentDTO.Git;
            this.CityId = tmpStudentDTO.CityId;
            this.Status = tmpStudentDTO.Status;
        }

        public override bool Equals(object obj)
        {
            return Equals((StudentDTO)obj);
        }

        private bool Equals(StudentDTO actual)
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
