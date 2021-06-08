using System;


namespace TrackingProgressInDevEducationBLL.Models.Group
{
    /// <summary>
    /// Модель данных для ответа на запрос со страницы Group(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для ответа из DAL в UI
    /// </summary>
    public class SetGroupA : ADTOAnswer
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SetGroupA()
        {
        }

        /// <summary>
        /// Конструктор для подготовки ответа
        /// </summary>
        /// <param name="id">Идентификатор объекта</param>
        /// <param name="isActivated">Параметр проверки на активацию аккаунта</param>
        /// <param name="email">"Электронная почта</param>
        /// <param name="fullName">Передаваемое  имя</param>
        public SetGroupA(string name, int courseId, string startDate, string endDate)
        {
            Name = name;
            CourseId = courseId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((SetGroupA)obj);
        }

        private bool Equals(SetGroupA other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
