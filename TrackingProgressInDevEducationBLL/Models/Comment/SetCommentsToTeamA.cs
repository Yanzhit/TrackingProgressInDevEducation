using System;

namespace TrackingProgressInDevEducationBLL.Models.Comment
{
    public class SetCommentsToTeamA : ADTOAnswer
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int CreatedBy { get; set; }
        public int? TeamId { get; set; }
        public int? Estimation { get; set; }

        public SetCommentsToTeamA()
        {
        }

        public SetCommentsToTeamA(string text, int typeId, int createdBy, int teamId, int estimation)
        {
            Text = text;
            TypeId = typeId;
            CreatedBy = createdBy;
            TeamId = teamId;
            Estimation = estimation;
        }

        public override bool Equals(object obj)
        {
            return Equals((SetCommentsToTeamA)obj);
        }

        private bool Equals(SetCommentsToTeamA other)
        {
            return Text == other.Text
                   && TypeId == other.TypeId
                   && CreatedBy == other.CreatedBy
                   && TeamId == other.TeamId
                   && Estimation == other.Estimation;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, TypeId, CreatedBy, TeamId, Estimation);
        }
    }
}
