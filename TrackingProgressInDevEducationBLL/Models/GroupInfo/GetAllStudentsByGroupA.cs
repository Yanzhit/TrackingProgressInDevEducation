using System;


namespace TrackingProgressInDevEducationBLL.Models.GroupInfo
{
    public class GetAllStudentsByGroupA : ADTOAnswer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Rate { get; set; }
        public int? GroupId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contract { get; set; }
        public string Birthday { get; set; }
        public string MiddleName { get; set; }
        public string Git { get; set; }
        public int? CityId { get; set; }
        public bool? Status { get; set; }

        public GetAllStudentsByGroupA()
        {  
        }
        public GetAllStudentsByGroupA(string name, string surname, int? rate, int? groupId, string phone,
            string email, string contract, string birthday, string middleName, string git, int? cityId, bool? status)
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
            return Equals((GetAllStudentsByGroupA)obj);
        }

        private bool Equals(GetAllStudentsByGroupA other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && Surname == other.Surname
                   && Rate == other.Rate
                   && GroupId == other.GroupId
                   && Phone == other.Phone
                   && Email == other.Email
                   && Contract == other.Contract
                   && Birthday == other.Birthday
                   && MiddleName == other.MiddleName
                   && Git == other.Git
                   && CityId == other.CityId
                   && Status == other.Status;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Rate, GroupId, Phone, CityId, Status);
        }
    }
}
