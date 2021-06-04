using System;
using System.Collections.Generic;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BComment
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
            Mapper mapper = new Mapper(config);

            BComment tmpBComment = new BComment();
            tmpBComment = mapper.Map<BComment>(comment);
        }

        public List<BComment> GetBComments(List<Comment> comments)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Comment>, List<BComment>>());
            Mapper mapper = new Mapper(config);

            List<BComment> tmpBComments = new List<BComment>();
            tmpBComments = mapper.Map<List<BComment>>(comments);
            return tmpBComments;
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
