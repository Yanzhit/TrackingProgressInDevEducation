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
                new(new object[] {1,2}),
                new(new object[] {2,2}),
                new(new object[] {3,2}),
                new(new object[] {1,1}),
                new(new object[] {1,2}),
                new(new object[] {3,2}),
                new(new object[] {1,1})
            };
        }
    }
}