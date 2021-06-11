using System;


namespace TrackingProgressInDevEducationBLL.Models.Group
{
    /// <summary>
    /// Модель данных для ответа на запрос со страницы Course(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для ответа из DAL в UI
    /// </summary>
    public class SetNewCoursesA : ADTOAnswer
    {
        public string Name { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SetNewCoursesA()
        {
        }
        /// <summary>
        /// Конструктор для подготовки ответа
        /// </summary>
        /// <param name="name">название группы</param>
        public SetNewCoursesA(string name)
        {
            Name = name;
        }
        public override bool Equals(object obj)
        {
            return Equals((SetNewCoursesA)obj);
        }

        private bool Equals(SetNewCoursesA other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
