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
        public string GroupName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contract { get; set; }
        public string Birthday { get; set; }
        public string MiddleName { get; set; }
        public string Git { get; set; }
        public string? CityName { get; set; }
        public bool? Status { get; set; }
        public string CourseName { get; set; }

        public GetAllStudentsA()
        {
        }

        public GetAllStudentsA(GetAllStudentsA student)
        {
            Name = student.Name;
            Surname = student.Surname;
            Rate = student.Rate;
            GroupName = student.GroupName;
            Phone = student.Phone;
            Email = student.Email;
            Contract = student.Contract;
            Birthday = student.Birthday;
            MiddleName = student.MiddleName;
            Git = student.Git;
            CityName = student.CityName;
            Status = student.Status;
            CourseName = student.CourseName;
        }
        public GetAllStudentsA(object obj)
        {
            var student = (GetAllStudentsA)obj;
            Name = student.Name;
            Surname = student.Surname;
            Rate = student.Rate;
            GroupName = student.GroupName;
            Phone = student.Phone;
            Email = student.Email;
            Contract = student.Contract;
            Birthday = student.Birthday;
            MiddleName = student.MiddleName;
            Git = student.Git;
            CityName = student.CityName;
            Status = student.Status;
            CourseName = student.CourseName;
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
                   && GroupName == actual.GroupName
                   && Phone == actual.Phone
                   && Email == actual.Email
                   && Contract == actual.Contract
                   && Birthday == actual.Birthday
                   && MiddleName == actual.MiddleName
                   && Git == actual.Git
                   && CityName == actual.CityName
                   && Status == actual.Status
                   && CourseName == actual.CourseName;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(Name);
            hashCode.Add(Surname);
            hashCode.Add(Rate);
            hashCode.Add(GroupName);
            hashCode.Add(Phone);
            hashCode.Add(Email);
            hashCode.Add(Contract);
            hashCode.Add(Birthday);
            hashCode.Add(MiddleName);
            hashCode.Add(Git);
            hashCode.Add(CityName);
            hashCode.Add(Status);
            hashCode.Add(CourseName);
            return hashCode.ToHashCode();
        }
    }
}
