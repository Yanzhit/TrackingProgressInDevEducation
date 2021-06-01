using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class LectorCourse : AbstractModel
    {
        public int LectorId { get; set; }
        public int CourseId { get; set; }

        public LectorCourse()
        {
        }

        public LectorCourse(int lectorId, int courseId)
        {
            LectorId = lectorId;
            CourseId = courseId;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectorCourse)obj);
        }

        private bool Equals(LectorCourse other)
        {
            return LectorId == other.LectorId
                   && CourseId == other.CourseId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LectorId, CourseId);
        }
    }
}