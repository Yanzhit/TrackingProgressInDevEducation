using System.Collections.Generic;
using AutoMapper;

namespace TrackingProgressInDevEducationBLL
{
    public class Mapper
    {
        public TU Map<T, TU>(T from)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, TU>());
            var mapper = new AutoMapper.Mapper(config);
            return mapper.Map<TU>(from);
        }

        public IEnumerable<TU> Map<T, TU>(IEnumerable<T> from)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, TU>());
            var mapper = new AutoMapper.Mapper(config);
            return mapper.Map<IEnumerable<TU>>(from);
        }
    }
}
