namespace TrackingProgressInDevEducationBLL.Models
{
    /// <summary>
    /// Абстрактная модель данных для ответов, наследуется от общей модели данных
    /// </summary>
    public abstract class ADTOAnswer : ADTO
    {
        /// <summary>
        /// Id - идентификатор, используется в каждом ответе на запросы.
        /// </summary>
        public int Id { get; set; }
    }
}