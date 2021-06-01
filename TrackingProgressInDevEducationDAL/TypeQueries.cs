namespace TrackingProgressInDevEducationDAL
{
    public enum TypeQueries
    {
        /// <summary>
        /// Запрос с единственным возвращаемым объектом
        /// </summary>
        Single  = 0,
        /// <summary>
        /// Запрос с множественным возвращаемым объектом
        /// </summary>
        Several,
        /// <summary>
        /// Обнуление таблицы "НЕ ОПРЕДЕЛЕНО ВОЗВРАЩАЕМОЕ ЗНАЧЕНИЕ, НУЖНО УТОЧНЯТЬ"
        /// </summary>
        Nullify
    }
}