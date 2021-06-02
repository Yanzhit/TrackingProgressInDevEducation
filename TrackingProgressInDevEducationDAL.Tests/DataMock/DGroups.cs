using System;
using System.Collections.Generic;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База групп
    /// </summary>
    public class DGroups : ADMock
    {
        /// <summary>
        /// Список групп для заполнения BD
        /// </summary>
        public List<Group> Grops;

        /// <summary>
        ///  Инициализация базы групп
        /// </summary>
        public DGroups()
        {
            Grops = new List<Group>
            {
                new("Dev{ed} C# Base 1", 1),
                new("Dev{ed} C# Front 2", 2),
                new("Dev{ed} C# Mobile 3", 3),
                new("Dev{ed} C# Back 4", 4),
                new("Dev{ed} JAVA# Base 1", 5),
                new("Dev{ed} JAVA# Front 2", 6),
                new("Dev{ed} JAVA# Mobile 3", 7),
                new("Dev{ed} C# Back 4", 8),
            };
        }
    }
}