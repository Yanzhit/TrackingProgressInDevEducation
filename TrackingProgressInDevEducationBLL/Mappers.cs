using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace TrackingProgressInDevEducationBLL
{
    /// <summary>
    /// Автомаппер
    /// </summary>
    public class Mappers
    {
        /// <summary>
        /// Автомаппер для множества объектов
        /// </summary>
        /// <typeparam name="T">Входящая модель данных</typeparam>
        /// <typeparam name="TU">Модель в которую необходимо преобразовать</typeparam>
        /// <param name="from">Входящие данные</param>
        /// <returns>Абстрактную модель данных</returns>
        public IEnumerable<TU> SeveralMapping<T, TU>(IEnumerable<T> from)
        {
            //Каждый элемент из from выбираем Select и применяем к нему метод (SingleMapping<T, TU>)
            //Далее собираем это в лист .ToList(); //Альтернатива foreach
            return @from.Select(SingleMapping<T, TU>).ToList();
        }

        /// <summary>
        /// Автомаппер
        /// </summary>
        /// <typeparam name="T">Входящая модель данных</typeparam>
        /// <typeparam name="TU">Модель в которую необходимо преобразовать</typeparam>
        /// <param name="from">Входящие данные</param>
        /// <returns>Абстрактную модель данных</returns>
        public TU SingleMapping<T, TU>(T from)
        {
            MapperConfiguration config = WriteConfig<T, TU>();
            Source<T> source = WriteSource(from);
            Mapper map = NewMapper(config);
            return map.Map<Source<T>, Destination<TU>>(source).Value;
        }
        
        /// <summary>
        /// Создание настроек для автомаппера
        /// </summary>
        /// <typeparam name="T">Входящая модель данных</typeparam>
        /// <typeparam name="TU">Модель в которую необходимо преобразовать</typeparam>
        /// <returns>Возвращает файл настроек</returns>
        private MapperConfiguration WriteConfig<T, TU>()
        {
            return new(cfg =>
            {
                cfg.CreateMap(typeof(Source<>), typeof(Destination<>));
                cfg.CreateMap<T, TU>();
            });
        }

        /// <summary>
        /// Создание ресурсов для автомаппера
        /// </summary>
        /// <typeparam name="T">Входящий модель с данными на основе их делается ресурсы</typeparam>
        /// <param name="from"></param>
        /// <returns>Ресурсы</returns>
        private Source<T> WriteSource<T>(T from)
        {
            return new() { Value = from };
        }

        /// <summary>
        /// Создание нового автомаппера на основе настроек
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        private Mapper NewMapper(MapperConfiguration config)
        {
            return new(config);
        }
    }
}
