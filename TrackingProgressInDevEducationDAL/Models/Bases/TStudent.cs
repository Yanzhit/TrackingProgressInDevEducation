﻿using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class TStudent : AbstractModel
    {
        public int TeamId { get; }
        public int StudentId { get; }

        public TStudent()
        {
        }

        public TStudent(TStudent tStudent) : base(tStudent)
        {
            TeamId = tStudent.TeamId;
            StudentId = tStudent.StudentId;
        }

        public override bool Equals(object obj)
        {
            return Equals((TStudent)obj);
        }

        private bool Equals(TStudent other)
        {
            return Id == other.Id
                   && TeamId == other.TeamId
                   && StudentId == other.StudentId;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(TeamId);
            hashCode.Add(StudentId);
            return hashCode.ToHashCode();
        }
    }
}