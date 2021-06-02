using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База выполненного дз
    /// </summary>
    public class DHWCompletes : ADMock
    {
        /// <summary>
        /// Список выполненного дз для заполнения BD
        /// </summary>
        public List<HWComplete> HWCompletes { get; }

        /// <summary>
        /// Инициализация базы выполненного дз
        /// </summary>
        public DHWCompletes()
        {
            HWCompletes = new List<HWComplete>
            {
                new (1, 4, 1),
                new (2, 2, 3),
                new (3, 3, 1),
                new (1, 1, 4),
                new (2, 2, 1)
            };
        }
    }
}