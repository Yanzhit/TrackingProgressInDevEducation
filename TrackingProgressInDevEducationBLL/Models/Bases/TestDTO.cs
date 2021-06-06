using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class TestDTO : ADTOAnswer
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public TestDTO()
        {
        }

        public TestDTO(Test test)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Test, TestDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            TestDTO tmpTestDTO = mapper.Map<TestDTO>(test);

            this.Name = tmpTestDTO.Name;
            this.Description = tmpTestDTO.Description;
        }

        public override bool Equals(object obj)
        {
            return Equals((TestDTO)obj);
        }

        private bool Equals(TestDTO other)
        {
            return Name == other.Name
                   && Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }
    }
}
