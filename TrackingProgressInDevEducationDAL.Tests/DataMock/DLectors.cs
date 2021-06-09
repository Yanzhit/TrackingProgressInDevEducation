using System.Collections.Generic;
using System.Net.Mail;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База лекторов
    /// </summary>
    public class DLectors : ADMock
    {
        /// <summary>
        /// Список лекторов для заполнения BD
        /// </summary>
        public List<Lector> Lectors { get; }

        /// <summary>
        /// Инициализация базы лекторов
        /// </summary>
        public DLectors()
        {
            Lectors = new List<Lector>
            {
                new("Wood","Петров Митя М", "iieqw@MailAddress.ru", "QQQ"),
                new("Wood","Петров Митя М", "iieqw@MailAddress.ru", "QQQ"),
                new("Wood","Петров Митя М", "iieqw@MailAddress.ru", "QQQ"),
                new("Wood","Петров Митя М", "iieqw@MailAddress.ru", "QQQ"),
                new("Wood","Петров Митя М", "iieqw@MailAddress.ru", "QQQ"),
                new("Wood","Петров Митя М", "iieqw@MailAddress.ru", "QQQ")
            };
        }
    }
}