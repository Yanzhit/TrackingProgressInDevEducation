using System;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class TeamStudent : IModels
    {
        public int TeamId { get; set; }
        public int StudentId { get; set; }

        public override bool Equals(object obj)
        {
            return Equals((TeamStudent)obj);
        }

        private bool Equals(TeamStudent other)
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