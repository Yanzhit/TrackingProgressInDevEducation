using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База групп лектора
    /// </summary>
    public class DLectorGroup : ADMock
    {
        /// <summary>
        /// Список групп лектора для заполнения BD
        /// </summary>
        public List<LectorGroup> LectorGroups { get; set; }

        /// <summary>
        /// Инициализация базы групп лектора
        /// </summary>
        public DLectorGroup()
        {
            LectorGroups = new List<LectorGroup>
            {
                new(2, 3),
                new(1, 3),
                new(3, 2),
                new(1, 1),
                new(2, 3),
                new(3, 1),
                new(1, 3)
            };
        }
    }
}