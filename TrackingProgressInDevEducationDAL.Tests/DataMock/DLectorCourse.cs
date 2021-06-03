using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База курсов лектора
    /// </summary>
    public class DLectorCourse : ADMock
    {
        /// <summary>
        /// Список курсов лектора для заполнения BD
        /// </summary>
        public List<LectorCourse> LectorCourses { get; }

        /// <summary>
        /// Инициализация базы курсов лектора
        /// </summary>
        public DLectorCourse()
        {
            LectorCourses = new List<LectorCourse>
            {
                new(1, 2),
                new(2, 1),
                new(3, 2),
                new(2, 3),
                new(3, 1),
                new(2, 2),
                new(2, 1)
            };
        }
    }
}