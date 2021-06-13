using System;

namespace TrackingProgressInDevEducationBLL.Models.Course
{
    /// <summary>
    /// Модель данных для запроса со страницы Course (определяется именем папки, которое соответствует конкретным страницам
    /// Модель для запроса из UI в DAL
    /// </summary>
    public class SetNewCoursesQ : ADTOQuery
    {
        /// <summary>
        /// Название Курса 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание курса
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SetNewCoursesQ()
        {
        }

        /// <summary>
        /// Конструктор для данного запроса
        /// </summary>
        /// <param name="name">название курса </param>
        /// <param name="description">описание курса</param>
        public SetNewCoursesQ(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override bool Equals(object obj)
        {
            return Equals((SetNewCoursesQ)obj);
        }

        private bool Equals(SetNewCoursesQ other)
        {
            return Name == other.Name
                   && Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }
    }
}