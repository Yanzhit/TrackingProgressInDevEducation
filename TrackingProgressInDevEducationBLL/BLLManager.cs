﻿using TrackingProgressInDevEducationBLL.Answers;
using TrackingProgressInDevEducationBLL.Queries;

namespace TrackingProgressInDevEducationBLL
{
    /// <summary>
    /// Фасад Блл
    /// </summary>
    public class BLLManager
    {
        /// <summary>
        /// Запрос со страниц SignIn
        /// </summary>
        public QSignIns QSignIns => new();

        /// <summary>
        /// Ответы на запросы со страниц SignIn
        /// </summary>
        public ASignIns ASignIns => new();
    }
}