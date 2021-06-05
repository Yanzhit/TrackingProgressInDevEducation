using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TrackingProgressInDevEducationBLL.BLLModels.Bases;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.BLLModels
{
    public class BLLMapper
    {
        public U Map<T, U>(T from)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, U>());
            Mapper mapper = new Mapper(config);
            return mapper.Map<U>(from);
        }

        public IEnumerable<U> Map<T, U>(IEnumerable<T> from)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, U>());
            Mapper mapper = new Mapper(config);
            return mapper.Map<IEnumerable<U>>(from);
        }
    }
}
