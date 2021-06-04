using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationBLL.BLLModels.Bases;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels
{
    public class BLLMapper
    {
        public class DTOToBLL
        {
            public BCity CityToBCity(City city)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<City, BCity>());
                Mapper mapper = new Mapper(config);

                BCity tmpBCity = new BCity();
                tmpBCity = mapper.Map<BCity>(city);

                return tmpBCity;
            }

            public List<BCity> GetCities(List<City> cities)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<List<City>, List<BCity>>());
                Mapper mapper = new Mapper(config);

                List<BCity> tmpBCities = new List<BCity>();
                tmpBCities = mapper.Map<List<BCity>>(cities);

                return tmpBCities;
            }
        }

        public class BLLToDTO
        {
            public City BCityToCity(BCity bCity)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<BCity, City>());
                Mapper mapper = new Mapper(config);

                City tmpCity = mapper.Map<City>(bCity);

                return tmpCity;
            }

        }
    }
}
