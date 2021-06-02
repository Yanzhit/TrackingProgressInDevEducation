using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BComment : BAbstractModel
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int StudentId { get; set; }
        public int CreatedBy { get; set; }
        public int TeamId { get; set; }

        public BComment()
        {
        }

        public BComment(Comment comment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, BComment>());
            Mapper mapper = new Mapper(config);

            BComment tmpBComment = new BComment();
            tmpBComment = mapper.Map<BComment>(comment);
            if (tmpBComment.Text != null)
            {
                this.Text = tmpBComment.Text;
            }
            if (tmpBComment.TypeId != null)
            {
                this.TypeId = tmpBComment.TypeId;
            }
            if (tmpBComment.StudentId != null)
            {
                this.StudentId = tmpBComment.StudentId;
            }
            if (tmpBComment.CreatedBy != null)
            {
                this.CreatedBy = tmpBComment.CreatedBy;
            }
            if (tmpBComment.TeamId != null)
            {
                this.TypeId = tmpBComment.TypeId;
            }
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
                   && TeamId == other.TeamId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, TypeId, StudentId, CreatedBy, TeamId);
        }
    }
}
