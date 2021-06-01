using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Requests.Tables;
using Student = TrackingProgressInDevEducationDAL.Models.Bases.Student;
using TrackingProgressInDevEducationDAL.Abstarcts;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Students : AFacade
    {
        public QStudent Query { get; set; }

        public IEnumerable<Student> GetAllStudents()
        {
            return (IEnumerable<Student>)_querySet.QuerySet(Query.GetAllStudents());
        }

        //public static Student SetNewStudent
        //    (
        //        string name,
        //        string surname,
        //        decimal rate,
        //        int groupId,
        //        string phone,
        //        string email,
        //        string contract,
        //        DateTime birthday,
        //        string middleName,
        //        string git,
        //        int cityId,
        //        bool status
        //    )
        //{
        //    return (Student)QuerySettings.QuerySet(Query.SetNewStudent
        //        (
        //            name,
        //            surname,
        //            rate,
        //            groupId,
        //            phone,
        //            email,
        //            contract,
        //            birthday,
        //            middleName,
        //            git,
        //            cityId,
        //            status
        //        )
        //    );
        //}
        //public static IEnumerable<Student> GetStudents()
        //{
        //    return (List<Student>)QuerySettings.QuerySet(Query.GetAllStudents());
        //}
        //public static IEnumerable<Student>  NullifyStudents()
        //{
        //    return (List<Student>)QuerySettings.QuerySet(Query.NullifyStudents());
        //}

        //public static Student GetByIdStudent(int id)
        //{
        //    return (Student)QuerySettings.QuerySet(Query.GetByIdStudent(id));
        //}
        
    }
}