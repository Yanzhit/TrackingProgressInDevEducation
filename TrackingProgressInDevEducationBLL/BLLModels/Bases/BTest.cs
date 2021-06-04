using System;
using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BTest
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public BTest()
        {
        }

        public BTest(Test test)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Test, BTest>());
            Mapper mapper = new Mapper(config);
            BTest tmpBTest = mapper.Map<BTest>(test);

            this.Name = tmpBTest.Name;
            this.Description = tmpBTest.Description;
        }

        public override bool Equals(object obj)
        {
            return Equals((BTest)obj);
        }

        private bool Equals(BTest other)
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
