using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
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
                var dCities = new DCities();
                dCities.Count = dCities.Name.Length;
                return dCities;
            }
        }

        public DComments DComments
        {
            get
            {
                var dComments = new DComments();
                var value = FindMinValue(dComments.StudentId.Length, dComments.CreatedBy.Length);
                value = FindMinValue(value, dComments.TeamId.Length);
                value = FindMinValue(value, dComments.Text.Length);
                value = FindMinValue(value, dComments.TypeId.Length);
                dComments.Count = value;
                return dComments;
            }
        }
        public DCTypes DCTypes => new();
        public DCourse DCourses => new();
        public DGroups DGroups => new();
        public DHomeworks DHomeworks => new();
        public DHWCompletes DHWCompletes => new();
        public DHWGroups DHWGroups => new();
        public DLections DLections => new();
        public DLectors DLectors  => new();
        public DLectorCourse DLectorCourses => new();
        public DLectorGroup DLectorGroups => new();
        public DPayments DPayments  => new();
        public DStudents DStudents => new();
        public DTeams DTeams  => new();
        public DTStudents DTStudents => new();
        public DVisits DVisits  => new();

        private int FindMinValue(int valueA, int valueB)
        {
            return valueA > valueB ? valueB : valueA;
        }
    }
}