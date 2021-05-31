using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Requests.ForTables;
using Student = TrackingProgressInDevEducationDAL.Models.Bases.Student;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Students
    {
        private static readonly QStudent Query = new();
        public static Student SetNewStudent
            (
                string name,
                string surname,
                decimal rate,
                int groupId,
                string phone,
                string email,
                string contract,
                DateTime birthday,
                string middleName,
                string git,
                int cityId,
                bool status
            )
        {
            return (Student)QuerySettings.QuerySet(Query.SetNewStudent
                (
                    name,
                    surname,
                    rate,
                    groupId,
                    phone,
                    email,
                    contract,
                    birthday,
                    middleName,
                    git,
                    cityId,
                    status
                )
            );
        }
        public static IEnumerable<Student> GetStudents()
        {
            return (List<Student>)QuerySettings.QuerySet(Query.GetAllStudents());
        }
        public static IEnumerable<Student>  NullifyStudents()
        {
            return (List<Student>)QuerySettings.QuerySet(Query.NullifyStudents());
        }

        //public static Student GetByIdStudent(int id)
        //{
        //    return (Student)QuerySettings.QuerySet(Query.GetByIdStudent(id));
        //}
        
    }
}