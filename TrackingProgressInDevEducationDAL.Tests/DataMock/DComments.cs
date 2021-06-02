using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База Комментариев
    /// </summary>
    public class DComments : ADMock
    {
        /// <summary>
        /// Список комментариев для заполнения BD
        /// </summary>
        public List<Comment> Comments { get; }

        /// <summary>
        /// Инициализация базы комментариев
        /// </summary>
        public DComments()
        {
            Comments = new List<Comment>
            {
                new ("Комментарий первый", 2, 3, 2, 1),
                new ("Комментарий второй", 2, 3, 2, 1),
                new ("Комментарий третий", 2, 3, 2, 1),
                new ("Комментарий четвертый", 2, 3, 2, 1),
                new ("Комментарий пятый", 2, 3, 2, 1),
                new ("Комментарий шестой", 2, 3, 2, 1),
                new ("Комментарий седьмой", 2, 3, 2, 1),
                new ("Комментарий восьмой", 2, 3, 2, 1),
                new ("Комментарий девятый", 2, 3, 2, 1)
            };
        }
    }
}