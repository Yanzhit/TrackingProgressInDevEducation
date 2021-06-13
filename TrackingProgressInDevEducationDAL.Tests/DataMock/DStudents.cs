using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База студентов
    /// </summary>
    public class DStudents : ADMock
    {
        /// <summary>
        /// Список студентов для заполнения BD
        /// </summary>
        public List<GetAllStudentsJ> Students { get; }

        /// <summary>
        /// Инициализация базы студентов
        /// </summary>
        public DStudents()
        {
            Students = new List<GetAllStudentsJ>
            {
                new(new object[] {"s", "s", 58m, 3, "567", "we@ya.ru", "07#971"
                    , "DateTime.MinValue", "op1", "wqw.git", 3, true}),
                new(new object[] {"sy", "sx", 90m, 1, "864", "we@ya.ru", "07#232"
                    , "DateTime.MinValue", "ogs", "w2qa.git", 3, true}),
                new(new object[] {"Sf", "as", 40m, 3, "15", "we@ya.ru", "07#102"
                    , "DateTime.MinValue", "ops", "w4.git", 3, true}),
                new(new object[] {"rwq", "fs", 98m, 4, "667", "wwe@ya.ru", "07#752"
                    , "DateTime.MinValue", "ops", "w32.git", 3, true}),
                new(new object[] {"sq", "sx", 32m, 5, "881", "wde@ya.ru", "07#202"
                    , "DateTime.MinValue", "oas", "w1.git", 3, true}),
                new(new object[] {"sr", "ws", 19m, 1, "999", "wze@ya.ru", "07#42"
                    , "DateTime.MinValue", "rps", "wr.git", 3, true}),
            };
        }
    }
}