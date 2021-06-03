using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База группового дз
    /// </summary>
    public class DHWGroups : ADMock
    {
        /// <summary>
        /// Список группового дз для заполнения BD
        /// </summary>
        public List<HWGroup> HWGroups { get; }

        /// <summary>
        /// Инициализация базы группового дз
        /// </summary>
        public DHWGroups()
        {
            HWGroups = new List<HWGroup>
            {
                new(1,2),
                new(2,2),
                new(3,2),
                new(1,1),
                new(1,2),
                new(3,2),
                new(1,1)
            };
        }
    }
}