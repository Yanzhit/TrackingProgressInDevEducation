﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Group
{
    /// <summary>
    /// Модель данных для ответа на запрос со страницы Group(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для ответа из DAL в UI
    /// </summary>
    public class SetCoursesA : ADTOAnswer
    {
        public string Name { get; set; }
        public string StartedOn { get; set; }
        public string FinishedOn { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SetCoursesA()
        {
        }

        /// <summary>
        /// Конструктор для подготовки ответа
        /// </summary>
        /// <param name="name">Название курса</param>
        /// <param name="startedOn">начала курса</param>
        /// <param name="finishedOn">конец курса</param>
        public SetCoursesA(string name, string startedOn, string finishedOn)
        {
            Name = name;
            StartedOn = startedOn;
            FinishedOn = finishedOn;
        }
        public override bool Equals(object obj)
        {
            return Equals((SetCoursesA)obj);
        }

        private bool Equals(SetCoursesA other)
        {
            return Id == other.Id
                && Name == other.Name
                && StartedOn == other.StartedOn
                && FinishedOn == other.FinishedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
