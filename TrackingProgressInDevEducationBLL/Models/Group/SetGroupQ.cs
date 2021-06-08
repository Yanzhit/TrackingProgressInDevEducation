using System;


namespace TrackingProgressInDevEducationBLL.Models.Group
{
    /// <summary>
    /// Модель данных для запроса со страницы Group(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для запроса из UI в DAL
    /// </summary>
    public class SetGroupQ : ADTOQuery
    {
        /// <summary>
        /// Имя группы 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ID Курса 
        /// </summary>
        public int CourseId { get; set; }
        /// <summary>
        /// Дата началы курса
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Дата окончания курса
        /// </summary>
        public DateTime EndDate { get; set; }
       
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SetGroupQ()
        {

        }
        /// <summary>
        /// Конструктор для данного запроса
        /// </summary>
        /// <param name="nameGroup">название группы </param>
        /// <param name="courseId">id группы</param>
        /// <param name="dataStartCousrses">дата начала курса</param>
        /// <param name="dataEndCousrses">дата окончания курса</param>
        public SetGroupQ(string name, int courseId, DateTime startDate, DateTime endDate)
        {
            Name = name;
            CourseId = courseId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((SetGroupQ)obj);
        }

        private bool Equals(SetGroupQ other)
        {
            return Name == other.Name
                   && CourseId == other.CourseId
                   && StartDate == other.StartDate
                   && EndDate == other.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, CourseId, StartDate, EndDate);
        }
    }
}
