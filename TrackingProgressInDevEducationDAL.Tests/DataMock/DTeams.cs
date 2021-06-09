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
                new(new object[] {"Jujy`r", "DateTime.MaxValue", "DateTime.MaxValue"}),
                new(new object[] {"Jujadr", "DateTime.MaxValue", "DateTime.MaxValue"}),
                new(new object[] {"Пиво", "DateTime.MaxValue", "DateTime.MaxValue"}),
                new(new object[] {"Kjjw", "DateTime.MaxValue", "DateTime.MaxValue"}),
                new(new object[] {"ШГЩц", "DateTime.MaxValue", "DateTime.MaxValue"})
            };
        }
    }
}