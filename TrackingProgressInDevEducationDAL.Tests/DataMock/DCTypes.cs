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
        public List<CType> CTypes;

        /// <summary>
        /// Инициализация базы типов комментариев
        /// </summary>
        public DCTypes()
        {
            CTypes = new List<CType>
            {
                new("Общий"),
                new("Soft"),
                new("Hard"),
                new("Team")
            };
        }
    }
}