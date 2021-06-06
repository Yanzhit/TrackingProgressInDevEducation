using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BCommentFor : AbstractBModel
    {
        public string Name { get; set; }

        public BCommentFor()
        {
        }
        public BCommentFor(CommentFor commentFor)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, BComment>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BCommentFor tmpBCommentFor = mapper.Map<BCommentFor>(commentFor);

            this.Name = tmpBCommentFor.Name;
        }

        public List<BCommentFor> GetBComments(List<CommentFor> commentsFor)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CommentFor, BCommentFor>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            List<BCommentFor> tmpBComments = mapper.Map<List<BCommentFor>>(commentsFor);
            return tmpBComments;
        }
        public override bool Equals(object obj)
        {
            return Equals((BCommentFor)obj);
        }

        private bool Equals(BCommentFor other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name != null ? Name.GetHashCode() : 0);
        }
    }
}
