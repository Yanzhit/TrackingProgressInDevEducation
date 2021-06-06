using System;
using System.Collections.Generic;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BComment : AbstractBModel
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int? StudentId { get; set; }
        public int CreatedBy { get; set; }
        public int? TeamId { get; set; }
        public decimal? Estimation { get; set; }

        public BComment()
        {
        }

        public BComment(Comment comment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, BComment>());
            var mapper = new AutoMapper.Mapper(config);
            BComment tmpBComment = mapper.Map<BComment>(comment);

            this.Text = tmpBComment.Text;
            this.TypeId = tmpBComment.TypeId;
            this.StudentId = tmpBComment.StudentId;
            this.CreatedBy = tmpBComment.CreatedBy;
            this.TeamId = tmpBComment.TeamId;
            this.Estimation = tmpBComment.Estimation;
        }

        public override bool Equals(object obj)
        {
            return Equals((BComment)obj);
        }

        private bool Equals(BComment other)
        {
            return Text == other.Text
                   && TypeId == other.TypeId
                   && StudentId == other.StudentId
                   && CreatedBy == other.CreatedBy
                   && TeamId == other.TeamId
                   && Estimation == other.Estimation;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, TypeId, StudentId, CreatedBy, TeamId, Estimation);
        }
    }
}
