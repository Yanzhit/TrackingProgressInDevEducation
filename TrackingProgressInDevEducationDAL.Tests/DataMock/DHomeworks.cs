using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База домашнего задания
    /// </summary>
    public class DHomeworks : ADMock
    {
        /// <summary>
        /// Список домашнего задания для заполнения BD
        /// </summary>
        public readonly List<Homework> Homeworks;

        /// <summary>
        /// Инициализация базы домашнего задания
        /// </summary>
        public DHomeworks()
        {
            Homeworks = new List<Homework>
            {
                new(new object[] {"First","One"}),
                new(new object[] {"Level","Two"}),
                new(new object[] {"Operand","Tree"}),
                new(new object[] {"Varies","Try"}),
                new(new object[] {"Fail","Ew"}),
                new(new object[] {"God","non"})
            };
        }
    }
}