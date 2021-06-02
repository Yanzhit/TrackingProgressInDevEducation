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
                new (1, 4, true),
                new (2, 2, false),
                new (3, 3, true),
                new (1, 1, false),
                new (2, 2, false)
            };
        }
    }
}