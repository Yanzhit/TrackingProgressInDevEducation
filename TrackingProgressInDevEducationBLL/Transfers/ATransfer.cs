using System;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    /// <summary>
    /// Абстракция класса трансфера
    /// </summary>
    public abstract class ATransfer
    {
        /// <summary>
        /// Модель данных для запроса в BD
        /// </summary>
        public Type Query { get; set; }

        /// <summary>
        /// Модель данных базовая(Используется из DAL)
        /// </summary>
        public Type Base { get; set; }
        
        /// <summary>
        /// Модель данных для обработки ответов BD
        /// </summary>
        public Type Answer { get; set; }

        protected ATransfer()
        {
        }
    }
}