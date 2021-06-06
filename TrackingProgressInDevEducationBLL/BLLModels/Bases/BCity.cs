using TrackingProgressInDevEducationDAL.Models.Bases;
using AutoMapper;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BCity : AbstractBModel
    {
        public string Name { get; set; }

        public BCity()
        {
        }

        public BCity(City city)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<City, BCity>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            BCity tmpBCity = mapper.Map<BCity>(city);

            this.Name = tmpBCity.Name;
        }

        public override bool Equals(object obj)
        {
            return Equals((BCity)obj);
        }

        private bool Equals(BCity other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    
    }
}
