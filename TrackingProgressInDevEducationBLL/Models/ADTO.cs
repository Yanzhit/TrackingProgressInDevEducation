namespace TrackingProgressInDevEducationBLL.Models
{
    /// <summary>
    /// Абстракция моделей данных DTO
    /// </summary>
    public abstract class ADTO
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        protected ADTO()
        {
        }

        /// <summary>
        /// Перезагрузка Equals для тестирования
        /// </summary>
        /// <param name="obj">Принимаемый объект данных</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return false;
        }

        /// <summary>
        /// Получение HashCod'a
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return -1;
        }
    }
}