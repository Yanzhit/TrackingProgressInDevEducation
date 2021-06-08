using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    public class GetGroupsByLectorQ : ADTOQuery
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public GetGroupsByLectorQ()
        {
        }

        public GetGroupsByLectorQ(int id, string name, int courseId, string startDate, string endDate)
        {
            Name = name;
            CourseId = courseId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public GetGroupsByLectorQ(int id)
        {
        }

        public override bool Equals(object obj)
        {
            return Equals((GetGroupsByLectorQ)obj);
        }

        private bool Equals(GetGroupsByLectorQ other)
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
