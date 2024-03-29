﻿using System;
using System.Collections.Generic;
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
        public List<Group> Groups;

        /// <summary>
        ///  Инициализация базы групп
        /// </summary>
        public DGroups()
        {
            Groups = new List<Group>
            {
                new("Dev{ed} C# Base 1", 1, DateTime.MinValue, DateTime.MinValue),
                new("Dev{ed} C# Front 2", 2, DateTime.MinValue, DateTime.MinValue),
                new("Dev{ed} C# Mobile 3", 3, DateTime.MinValue, DateTime.MinValue),
                new("Dev{ed} C# Back 4", 4, DateTime.MinValue, DateTime.MinValue),
                new("Dev{ed} JAVA# Base 1", 5, DateTime.MinValue, DateTime.MinValue),
                new("Dev{ed} JAVA# Front 2", 6, DateTime.MinValue, DateTime.MinValue),
                new("Dev{ed} JAVA# Mobile 3", 7, DateTime.MinValue, DateTime.MinValue),
                new("Dev{ed} C# Back 4", 8, DateTime.MinValue, DateTime.MinValue)
            };
        }
    }
}