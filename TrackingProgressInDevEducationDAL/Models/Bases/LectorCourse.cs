using System;

namespace TrackingProgressInDevEducationDAL.Models.Bases
{
    public class LectorCourse : AbstractModel
    {
        public int LectorId  { get; set; }
        public int CourseId  { get; set; }

        public LectorCourse()
        {
        }

        public LectorCourse(LectorCourse lectorCourse) : base(lectorCourse)
        {
            LectorId = lectorCourse.LectorId;
            CourseId = lectorCourse.CourseId;
        }
        public LectorCourse(object obj) : base(obj)
        {
            var lectorCourse = (LectorCourse) obj;
            LectorId = lectorCourse.LectorId;
            CourseId = lectorCourse.CourseId;
        }

        public override bool Equals(object obj)
        {
            return Equals((LectorCourse)obj);
        }

        private bool Equals(LectorCourse other)
        {
            return Id == other.Id
                   && LectorId == other.LectorId
                   && CourseId == other.CourseId;
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(base.GetHashCode());
            hashCode.Add(Id);
            hashCode.Add(LectorId);
            hashCode.Add(CourseId);
            return hashCode.ToHashCode();
        }
    }
}