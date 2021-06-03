using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class TStudent : AbstractModel
    {
        public int TeamId { get; set; }
        public int StudentId { get; set; }

        public TStudent()
        {
        }

        public TStudent(int teamId, int studentId)
        {
            TeamId = teamId;
            StudentId = studentId;
        }

        public override bool Equals(object obj)
        {
            return Equals((TStudent)obj);
        }

        private bool Equals(TStudent other)
        {
            return TeamId == other.TeamId
                   && StudentId == other.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TeamId, StudentId);
        }
    }
}