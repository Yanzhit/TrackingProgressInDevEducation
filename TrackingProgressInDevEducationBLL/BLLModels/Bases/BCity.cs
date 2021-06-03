using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using AutoMapper;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BCity
    {
        public string Name { get; set; }

        public BCity()
        {
        }

        public BCity(City city)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<City, BCity>());
            Mapper mapper = new Mapper(config);

            BCity tmpBCity = new BCity();
            tmpBCity = mapper.Map<BCity>(city);
            if (tmpBCity.Name != null)
            {
                this.Name = tmpBCity.Name;
            }
        }

        public List<BCity> GetCities(List<City> cities)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<City>, List<BCity>>());
            Mapper mapper = new Mapper(config);

            List<BCity> tmpBCities = new List<BCity>();
            tmpBCities = mapper.Map<List<BCity>>(cities);
            return tmpBCities;
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
