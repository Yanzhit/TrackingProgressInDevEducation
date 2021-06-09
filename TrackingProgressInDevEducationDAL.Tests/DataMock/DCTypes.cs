using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База типов комментариев
    /// </summary>
    public class DCTypes : ADMock
    {
        /// <summary>
        /// Список типов комментариев для заполнения BD
        /// </summary>
        public readonly List<CType> CTypes;

        /// <summary>
        /// Инициализация базы типов комментариев
        /// </summary>
        public DCTypes()
        {
            CTypes = new List<CType>
            {
                new(new object[] {"Общий"}),
                new(new object[] {"Soft"}),
                new(new object[] {"Hard"}),
                new(new object[] {"Team"})
            };
        }
    }
}