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
        public DCities DCities
        {
            get
            {
                var mock = new DCities();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DComments DComments
        {
            get
            {
                var mock = new DComments();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DCTypes DCTypes
        {
            get
            {
                var mock = new DCTypes();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DCourse DCourses
        {
            get
            {
                var mock = new DCourse();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DGroups DGroups
        {
            get
            {
                var mock = new DGroups();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DHomeworks DHomeworks
        {
            get
            {
                var mock = new DHomeworks();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DHWCompletes DHWCompletes
        {
            get
            {
                var mock = new DHWCompletes();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DHWGroups DHWGroups
        {
            get
            {
                var mock = new DHWGroups();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DLections DLections
        {
            get
            {
                var mock = new DLections();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DLectors DLectors
        {
            get
            {
                var mock = new DLectors();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DLectorCourse DLectorCourses
        {
            get
            {
                var mock = new DLectorCourse();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DLectorGroup DLectorGroups
        {
            get
            {
                var mock = new DLectorGroup();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DPayments DPayments
        {
            get
            {
                var mock = new DPayments();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DStudents DStudents
        {
            get
            {
                var mock = new DStudents();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DTeams DTeams
        {
            get
            {
                var mock = new DTeams();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DTStudents DTStudents
        {
            get
            {
                var mock = new DTStudents();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }

        public DVisits DVisits
        {
            get
            {
                var mock = new DVisits();
                mock.Count = GetMinCount(mock);
                return mock;
            }
        }
        
        private int GetMinCount(ADMock mock)
        {
            PropertyInfo[] props = mock.GetType().GetProperties();
            int minValue = props[0].DeclaringType.Assembly.CustomAttributes.Count();
            foreach (var length in props)
            {
                if (minValue > length.DeclaringType.Assembly.CustomAttributes.Count())
                {
                    minValue = length.DeclaringType.Assembly.CustomAttributes.Count();
                }
            }
            return minValue;
        }
    }
}