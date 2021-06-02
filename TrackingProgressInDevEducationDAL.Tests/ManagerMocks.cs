using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.DataMock;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class ManagerMocks
    {
        /// <summary>
        /// 
        /// </summary>
        public DCities DCities => new DCities();

        public DComments DComments => new DComments();

        public DCTypes DCTypes => new DCTypes();

        public DCourse DCourses => new DCourse();

        public DGroups DGroups => new DGroups();

        public DHomeworks DHomeworks => new DHomeworks();

        public DHWCompletes DHWCompletes => new DHWCompletes();

        public DHWGroups DHWGroups => new DHWGroups();
        public DLections DLections => new DLections();

        public DLectors DLectors => new DLectors();
        public DLectorCourse DLectorCourses => new DLectorCourse();

        public DLectorGroup DLectorGroups => new DLectorGroup();
        public DPayments DPayments => new DPayments();

        public DStudents DStudents => new DStudents();
        public DTeams DTeams => new DTeams();
        public DTStudents DTStudents => new DTStudents();
        public DVisits DVisits => new DVisits();
        
    }
}