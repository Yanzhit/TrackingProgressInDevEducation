﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Students
{
    public class GetAllStudentsA : ADTOAnswer
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

        public GetAllStudentsA()
        {
        }

        public GetAllStudentsA(object obj)
        {
            var student = (GetAllStudentsA)obj;
            Id = student.Id;
            Name = student.Name;
            Surname = student.Surname;
            Rate = student.Rate;
            GroupId = student.GroupId;
            Phone = student.Phone;
            Email = student.Email;
            Contract = student.Contract;
            Birthday = student.Birthday;
            MiddleName = student.MiddleName;
            Git = student.Git;
            CityId = student.CityId;
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
            hashCode.Add(Id);
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