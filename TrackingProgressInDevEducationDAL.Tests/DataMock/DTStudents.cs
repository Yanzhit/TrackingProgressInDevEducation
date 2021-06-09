using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База команд студентов
    /// </summary>
    public class DTStudents : ADMock
    {
        /// <summary>
        /// Список команд студентов для заполнения BD
        /// </summary>
        public List<TStudent> TStudents { get; }

        /// <summary>
        /// Инициализация базы команд студентов
        /// </summary>
        public DTStudents()
        {
            TStudents = new List<TStudent>
            {
                new(new object[] {1, 5}),
                new(new object[] {2, 2}),
                new(new object[] {3, 4}),
                new(new object[] {4, 1}),
                new(new object[] {1, 3}),
                new(new object[] {2, 5})
            };
        }
    }
}