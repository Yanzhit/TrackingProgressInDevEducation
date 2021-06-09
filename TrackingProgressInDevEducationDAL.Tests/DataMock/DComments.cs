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
                new(new object[] {"Комментарий первый", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий второй", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий третий", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий четвертый", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий пятый", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий шестой", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий седьмой", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий восьмой", 2, 3, 2, 1, 1}),
                new(new object[] {"Комментарий девятый", 2, 3, 2, 1, 1})
            };
        }
    }
}