using System.Collections.Generic;

namespace TrackingProgressInDevEducationBLL
{
    /// <summary>
    /// Не типизированный контейнер ресурсов для моделей под Автомаппер
    /// </summary>
    /// <typeparam name="T">Принимает параметры типа ADTO</typeparam>
    public class Source<T>
    {
        /// <summary>
        /// Контейнер
        /// </summary>
        public T Value { get; set; }
    }
}