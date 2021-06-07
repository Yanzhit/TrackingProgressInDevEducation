using System;


namespace TrackingProgressInDevEducationBLL.Models.Group
{
    /// <summary>
    /// Модель данных для ответа на запрос со страницы Group(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для ответа из DAL в UI
    /// </summary>
    public class GroupAnswer : ADTOAnswer
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public GroupAnswer()
        {
        }

        /// <summary>
        /// Конструктор для подготовки ответа
        /// </summary>
        /// <param name="id">Идентификатор объекта</param>
        /// <param name="isActivated">Параметр проверки на активацию аккаунта</param>
        /// <param name="email">"Электронная почта</param>
        /// <param name="fullName">Передаваемое  имя</param>
        public GroupAnswer(string name, int courseId, DateTime startDate, DateTime endDate)
        {
            Name = name;
            CourseId = courseId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((GroupAnswer)obj);
        }

        private bool Equals(GroupAnswer other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
