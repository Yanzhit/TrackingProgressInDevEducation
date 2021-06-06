using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class CommentDTO : ADTOAnswer
    {
        public string Text { get; set; }
        public int TypeId { get; set; }
        public int? StudentId { get; set; }
        public int CreatedBy { get; set; }
        public int? TeamId { get; set; }
        public decimal? Estimation { get; set; }

        public CommentDTO()
        {
        }

        public CommentDTO(Comment comment)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentDTO>());
            var mapper = new AutoMapper.Mapper(config);
            CommentDTO tmpCommentDto = mapper.Map<CommentDTO>(comment);

            this.Text = tmpCommentDto.Text;
            this.TypeId = tmpCommentDto.TypeId;
            this.StudentId = tmpCommentDto.StudentId;
            this.CreatedBy = tmpCommentDto.CreatedBy;
            this.TeamId = tmpCommentDto.TeamId;
            this.Estimation = tmpCommentDto.Estimation;
        }

        public override bool Equals(object obj)
        {
            return Equals((CommentDTO)obj);
        }

        private bool Equals(CommentDTO other)
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
