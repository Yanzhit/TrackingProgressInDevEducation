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
        public List<Homework> Homeworks;

        /// <summary>
        /// Инициализация базы домашнего задания
        /// </summary>
        public DHomeworks()
        {
            Homeworks = new List<Homework>
            {
                new("First","One"),
                new("Level","Two"),
                new("Operand","Tree"),
                new("Varies","Try"),
                new("Fail","Ew"),
                new("God","non")
            };
        }
    }
}