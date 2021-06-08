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
        /// <param name="name">название группы</param>
        /// <param name="courseId">ид курса</param>
        /// <param name="startDate">дата создания группы</param>
        /// <param name="endDate">дата окончания группы</param>
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
            return Id == other.Id
                && CourseId == other.CourseId
                && StartDate == other.StartDate
                && EndDate == other.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
