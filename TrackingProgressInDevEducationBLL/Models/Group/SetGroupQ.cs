using System;


namespace TrackingProgressInDevEducationBLL.Models.Group
{
    /// <summary>
    /// Модель данных для запроса со страницы Group(определяется именем папки, которое соответствует конкретным страницам
    /// Модель для запроса из UI в DAL
    /// </summary>
    public class SetGroupQ : ADTOQuery
    {
        public string Name { get; set; }
        public int? GroupId { get; set; }
        public int LectorId { get; set; }
        public int CourseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public SetGroupQ()
        {

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
