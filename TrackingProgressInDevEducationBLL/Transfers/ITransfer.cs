using System;

namespace TrackingProgressInDevEducationBLL.Transfers
{
    /// <summary>
    /// Типы моделей используемые для запроса со страницы SignIn для Lectora
    /// </summary>
    public interface ITransfer
    {
        /// <summary>
        /// Модель данных для запроса в BD
        /// </summary>
        Type Query { get; set; }

        /// <summary>
        /// Модель данных базовая(Используется из DAL)
        /// </summary>
        Type Base { get; set; }
        
        /// <summary>
        /// Модель данных для обработки ответов BD
        /// </summary>
        Type Answer { get; set; }
    }
}