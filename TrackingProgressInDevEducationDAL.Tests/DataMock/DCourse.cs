using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База курсов
    /// </summary>
    public class DCourse : ADMock
    {
        /// <summary>
        /// Список курсов для заполнения BD
        /// </summary>
        public List<Course> Courses { get; }

        /// <summary>
        /// Инициализация базы курсов
        /// </summary>
        public DCourse()
        {
            Courses = new List<Course>
            {
                new ("C# - default", "DateTime.MinValue", "DateTime.MaxValue"),
                new ("C# - Front", "DateTime.MinValue", "DateTime.MaxValue"),
                new ("C# - Back", "DateTime.MinValue", "DateTime.MaxValue"),
                new ("C# - Mobile", "DateTime.MinValue", "DateTime.MaxValue"),
                new ("Java - default", "DateTime.MinValue", "DateTime.MaxValue"),
                new ("Java - Front", "DateTime.MinValue", "DateTime.MaxValue"),
                new ("Java - Back", "DateTime.MinValue", "DateTime.MaxValue"),
                new ("Java - Mobile", "DateTime.MinValue", "DateTime.MaxValue")
            };
        }
    }
}