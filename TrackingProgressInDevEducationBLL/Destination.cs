namespace TrackingProgressInDevEducationBLL
{
    /// <summary>
    /// Не типизированный контейнер выходных моделей для моделей под Автомаппер
    /// </summary>
    /// <typeparam name="T">Принимает параметры типа ADTO</typeparam>
    public class Destination<T>
    {
        /// <summary>
        /// Контейнер
        /// </summary>
        public T Value { get; set; }
    }
}