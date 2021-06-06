using System;
using System.Collections.Generic;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class CommentForDTO : ADTOAnswer
    {
        public string Name { get; set; }

        public CommentForDTO()
        {
        }
        public CommentForDTO(CommentFor commentFor)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            CommentForDTO tmpCommentForDTO = mapper.Map<CommentForDTO>(commentFor);

            this.Name = tmpCommentForDTO.Name;
        }

        public List<CommentForDTO> GetBComments(List<CommentFor> commentsFor)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CommentFor, CommentForDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            List<CommentForDTO> tmpBComments = mapper.Map<List<CommentForDTO>>(commentsFor);
            return tmpBComments;
        }
        public override bool Equals(object obj)
        {
            return Equals((CommentForDTO)obj);
        }

        private bool Equals(CommentForDTO other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name != null ? Name.GetHashCode() : 0);
        }
    }
}
