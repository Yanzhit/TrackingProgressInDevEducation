using TrackingProgressInDevEducationBLL.Facades.ForTables;

namespace TrackingProgressInDevEducationBLL.Facades
{
    public class Facade
    {
        //public FacadeCities Cities => new FacadeCities();
        public FacadeCities Cities
        {
            get
            {
                return new FacadeCities();
            }
        }

        //public FacadeComments Comments => new FacadeComments();
        public FacadeComments Comments
        {
            get
            {
                return new FacadeComments();
            }
        }

        //public FacadeCommentType CommentType => new FacadeCommentType();
        public FacadeCommentType CommentType
        {
            get
            {
                return new FacadeCommentType();
            }
        }

        //public FacadeCourses Courses => new FacadeCourses();
        public FacadeCourses Courses
        {
            get
            {
                return new FacadeCourses();
            }
        }

        //public FacadeGroups Groups => new FacadeGroups();
        public FacadeGroups Groups
        {
            get
            {
                return new FacadeGroups();
            }
        }

        //public FacadeHomeworkComplete HomeworkComplete => new FacadeHomeworkComplete();
        public FacadeHomeworkComplete HomeworkComplete
        {
            get
            {
                return new FacadeHomeworkComplete();
            }
        }

        //public FacadeHomeworkGroup HomeworkGroup => new FacadeHomeworkGroup();
        public FacadeHomeworkGroup HomeworkGroup
        {
            get
            {
                return new FacadeHomeworkGroup();
            }
        }

        //public FacadeHomeworks Homeworks => new FacadeHomeworks();
        public FacadeHomeworks Homeworks
        {
            get
            {
                return new FacadeHomeworks();
            }
        }

        //public FacadeLections Lections => new FacadeLections();
        public FacadeLections Lections
        {
            get
            {
                return new FacadeLections();
            }
        }

        //public FacadeLectorCourses LectorCourses => new FacadeLectorCourses();
        public FacadeLectorCourses LectorCourses
        {
            get
            {
                return new FacadeLectorCourses();
            }
        }

        //public FacadeLectorGroup LectorGroup => new FacadeLectorGroup();
        public FacadeLectorGroup LectorGroup
        {
            get
            {
                return new FacadeLectorGroup();
            }
        }

        //public FacadeLectors Lectors => new FacadeLectors();
        public FacadeLectors Lectors
        {
            get
            {
                return new FacadeLectors();
            }
        }

        //public FacadePayments Payments => new FacadePayments();
        public FacadePayments Payments
        {
            get
            {
                return new FacadePayments();
            }
        }

        //public FacadeStudent Student => new FacadeStudent();
        public FacadeStudent Student
        {
            get
            {
                return new FacadeStudent();
            }
        }

        //public FacadeTeams Teams => new FacadeTeams();
        public FacadeTeams Teams
        {
            get
            {
                return new FacadeTeams();
            }
        }

        //public FacadeTeamStudent TeamStudent => new FacadeTeamStudent();
        public FacadeTeamStudent TeamStudent
        {
            get
            {
                return new FacadeTeamStudent();
            }
        }

        //public FacadeVisits Visits => new FacadeVisits();
        public FacadeVisits Visits
        {
            get
            {
                return new FacadeVisits();
            }
        }
    }
}
