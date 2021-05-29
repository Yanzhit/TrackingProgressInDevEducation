using System.Collections.Generic;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataComments
    {
        public int Count { get; }
        public string[] Text { get; }

        public int[] TypeId { get; }

        public int[] StudentId { get; }

        public int[] CreatedBy { get; }

        public DataComments()
        {
            Count = 10;
            Text = new[]
            {
                "Комментарий первый",
                "Хороший тип",
                "А он огонь",
                "So good",
                "Что ещё?",
                "Проверка связи",
                "Оладушек",
                "Карусель такая большая",
                "Веселый дядя гуру",
                "Амбиции не знают границ" //10
            };
            TypeId  = new[]
            {
                1, 2, 3, 4, 5, 6, 8, 9, 0, 7 //10
            };
            StudentId = new[]
            {
                1, 2, 3, 2, 3, 6, 8, 2, 0, 7 //10
            };
            CreatedBy = new[]
            {
                1, 2, 8, 2, 7, 5, 2, 2, 0, 1 //10
            };
        }
    }
}