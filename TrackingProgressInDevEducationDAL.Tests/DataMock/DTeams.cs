using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База команд
    /// </summary>
    public class DTeams : ADMock
    {
        /// <summary>
        /// Список команд для заполнения BD
        /// </summary>
        public List<Team> Teams { get; }
        
        /// <summary>
        /// Инициализация базы команд
        /// </summary>
        public DTeams()
        {
            Teams = new List<Team>
            {
                new("Jujy`r", "DateTime.MaxValue", "DateTime.MaxValue"),
                new("Jujadr", "DateTime.MaxValue", "DateTime.MaxValue"),
                new("Пиво", "DateTime.MaxValue", "DateTime.MaxValue"),
                new("Kjjw", "DateTime.MaxValue", "DateTime.MaxValue"),
                new("ШГЩц", "DateTime.MaxValue", "DateTime.MaxValue")
            };
        }
    }
}