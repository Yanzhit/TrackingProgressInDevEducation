using System;


namespace TrackingProgressInDevEducationBLL.Models.Comment
{
    public class SetCommentsToTeamQ : ADTOQuery
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int CreatedBy { get; set; }
        public int? TeamId { get; set; }
        public int? Estimation { get; set; }

        public SetCommentsToTeamQ()
        {
        }

        public SetCommentsToTeamQ(SetCommentsToTeamQ model)
        {
            Text = model.Text;
            TypeId = model.TypeId;            
            CreatedBy = model.CreatedBy;
            TeamId = model.TeamId;
            Estimation = model.Estimation;
        }

        public override bool Equals(object obj)
        {
            return Equals((SetCommentsToTeamQ)obj);
        }

        private bool Equals(SetCommentsToTeamQ other)
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
