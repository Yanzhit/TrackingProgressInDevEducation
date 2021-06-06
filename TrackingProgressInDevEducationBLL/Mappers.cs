using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace TrackingProgressInDevEducationBLL
{
    public class Mappers
    {

        public static IEnumerable<TU> SeveralMapping<T, TU>(IEnumerable<T> from)
        {
            //Каждый элемент из from выбираем Select и применяем к нему метод (SingleMapping<T, TU>)
            //Далее собираем это в лист .ToList(); //Альтернатива foreach
            return @from.Select(SingleMapping<T, TU>).ToList();
        }

        public static TU SingleMapping<T, TU>(T from)
        {
            MapperConfiguration config = WriteConfig<T, TU>();
            Source<T> source = WriteSource(from);
            Mapper map = NewMapper(config);
            return map.Map<Source<T>, Destination<TU>>(source).Value;
        }
        
        private static MapperConfiguration WriteConfig<T, TU>()
        {
            return new(cfg =>
            {
                cfg.CreateMap(typeof(Source<>), typeof(Destination<>));
                cfg.CreateMap<T, TU>();
            });
        }

        private static Source<T> WriteSource<T>(T from)
        {
            return new() { Value = from };
        }

        private static Mapper NewMapper(MapperConfiguration config)
        {
            return new(config);
        }
    }
}
