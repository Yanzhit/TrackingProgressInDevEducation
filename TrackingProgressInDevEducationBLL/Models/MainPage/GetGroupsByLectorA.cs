using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.MainPage
{
    public class GetGroupsByLectorA: ADTOAnswer
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public GetGroupsByLectorA()
        {
        }

        public GetGroupsByLectorA(int id, string name, int courseId, string startDate, string endDate)
        {
            Id = id;
            Name = name;
            CourseId = courseId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override bool Equals(object obj)
        {
            return Equals((GetGroupsByLectorA)obj);
        }

        private bool Equals(GetGroupsByLectorA other)
        {
            return Id == other.Id
                   && Name == other.Name
                   && CourseId == other.CourseId
                   && StartDate == other.StartDate
                   && EndDate == other.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, CourseId, StartDate, EndDate);
        }
    }
}