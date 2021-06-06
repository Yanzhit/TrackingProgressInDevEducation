using AutoMapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Models.Bases
{
    public class CityDTO : ADTOAnswer
    {
        public string Name { get; set; }

        public CityDTO()
        {
        }

        public CityDTO(City city)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<City, CityDTO>());
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(config);
            CityDTO tmpCityDTO = mapper.Map<CityDTO>(city);

            this.Name = tmpCityDTO.Name;
        }

        public override bool Equals(object obj)
        {
            return Equals((CityDTO)obj);
        }

        private bool Equals(CityDTO other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    
    }
}
