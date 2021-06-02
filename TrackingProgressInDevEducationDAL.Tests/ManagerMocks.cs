using TrackingProgressInDevEducationDAL.Tests.DataMock;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class ManagerMocks
    {
        /// <summary>
        /// 
        /// </summary>
        public DCities DCities => new();

        /// <summary>
        /// 
        /// </summary>
        public DComments DComments => new();

        /// <summary>
        /// 
        /// </summary>
        public DCTypes DCTypes => new();

        /// <summary>
        /// 
        /// </summary>
        public DCourse DCourses => new();

        /// <summary>
        /// 
        /// </summary>
        public DGroups DGroups => new();

        /// <summary>
        /// 
        /// </summary>
        public DHomeworks DHomeworks => new();

        /// <summary>
        /// 
        /// </summary>
        public DHWCompletes DHWCompletes => new();

        /// <summary>
        /// 
        /// </summary>
        public DHWGroups DHWGroups => new();

        public DLections DLections => new();

        /// <summary>
        /// 
        /// </summary>
        public DLectors DLectors => new();

        public DLectorCourse DLectorCourses => new();

        /// <summary>
        /// 
        /// </summary>
        public DLectorGroup DLectorGroups => new();

        /// <summary>
        /// 
        /// </summary>
        public DPayments DPayments => new();

        /// <summary>
        /// 
        /// </summary>
        public DStudents DStudents => new();

        /// <summary>
        /// 
        /// </summary>
        public DTeams DTeams => new();

        /// <summary>
        /// 
        /// </summary>
        public DTStudents DTStudents => new();

        /// <summary>
        /// 
        /// </summary>
        public DVisits DVisits => new();
    }
}