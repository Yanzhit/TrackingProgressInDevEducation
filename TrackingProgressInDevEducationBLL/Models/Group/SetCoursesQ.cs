using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationBLL.Models.Group
{
    public class SetCoursesQ : ADTOQuery
    {
        ///// <summary>
        ///// Название курса
        ///// </summary>
        //public string Name { get; set; }

        ///// <summary>
        ///// Дата начала курса 
        ///// </summary>
        //public string StartedOn { get; set; }

        ///// <summary>
        ///// Дата окончания курса
        ///// </summary>
        //public string FinishedOn { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SetCoursesQ()
        {
        }
        ///// <summary>
        ///// Конструктор для подготовки ответа
        ///// </summary>
        ///// <param name="name">название курса</param>
        ///// <param name="startedOn">дата создания курса</param>
        ///// <param name="finishedOn">дата окончания курса</param>
        //public SetCoursesQ(string name, string startedOn, string finishedOn)
        //{
        //    Name = name;
        //    StartedOn = startedOn;
        //    FinishedOn = finishedOn;
        //}

        public override bool Equals(object obj)
        {
            return Equals((SetCoursesQ)obj);
        }

        private bool Equals(SetCoursesQ other)
        {
            return true;
                //Name == other.Name
                //&& StartedOn == other.StartedOn
                //&& FinishedOn == other.FinishedOn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(true);
        }
    }
}
