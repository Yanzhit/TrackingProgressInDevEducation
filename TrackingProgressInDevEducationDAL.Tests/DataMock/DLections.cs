﻿using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База лекций
    /// </summary>
    public class DLections : ADMock
    {
        /// <summary>
        /// Список лекций для заполнения BD
        /// </summary>
        public List<Lection> Lections { get; }

        /// <summary>
        /// Инициализация базы лекций
        /// </summary>
        public DLections()
        {
            Lections = new List<Lection>
            {
                new(1,3,DateTime.MaxValue),
                new(1,3,DateTime.MaxValue),
                new(1,3,DateTime.MaxValue),
                new(1,3,DateTime.MinValue),
                new(1,3,DateTime.MinValue),
                new(1,3,DateTime.MinValue)
            };
        }
    }
}