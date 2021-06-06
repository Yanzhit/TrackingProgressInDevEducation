using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.SignIn;

namespace TrackingProgressInDevEducationBLL
{
    public class Mappers
    {

        //public static IEnumerable<Destination<TU>> SeveralMapping<T, TU>(IEnumerable<T> from)
        //{
        //    //Каждый элемент из from выбираем Select и применяем к нему метод (SingleMapping<T, TU>)
        //    //Далее собираем это в лист .ToList(); //Альтернатива foreach
        //    return @from.Select(SingleMapping<T, TU>).ToList();
        //}

        public static TU SingleMapping<T, TU>(T from)
        {
            MapperConfiguration config = WriteConfig<T, TU>();
            Source<T> source = WriteSource(from);
            Mapper map = NewMapper(config);
            var answer = map.Map<Source<T>, Destination<TU>>(source);
            return answer.Value;
        }
        

        private static Mapper NewMapper(MapperConfiguration config)
        {
            return new Mapper(config);
        }

        private static Source<T> WriteSource<T>(T from)
        {
            return new() { Value = from };
        }

        private static MapperConfiguration WriteConfig<T, TU>()
        {
            return new(cfg =>
            {
                cfg.CreateMap(typeof(Source<>), typeof(Destination<>));
                cfg.CreateMap<T, TU>();
            });
        }
    }
}
