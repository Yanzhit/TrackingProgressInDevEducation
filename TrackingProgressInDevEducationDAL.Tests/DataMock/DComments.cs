using System.Collections;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DComments : ADMock
    {
        public string[] Text { get; }

        public int[] TypeId { get; }

        public int[] StudentId { get; }

        public int[] CreatedBy { get; }
        public int[] TeamId { get; }

        public DComments()
        {
            Text = DataText();
            TypeId = DataTypeId();
            StudentId = DataStudentId();
            CreatedBy = DataCreatedBy();
            TeamId = DataTeamId();
        }

        private string[] DataText()
        {
            return new[]
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
        }

        private int[] DataTypeId()
        {
            return new[]
            {
                1, 2, 3, 4, 5, 6, 8, 9, 0, 7 //10
            };
        }
        private int[] DataStudentId()
        {
            return new[]
            {
                1, 2, 3, 2, 3, 6, 8, 2, 0, 7 //10
            };
        }
        private int[] DataCreatedBy()
        {
            return new[]
            {
                1, 2, 8, 2, 7, 5, 2, 2, 0, 1 //10
            };
        }

        private int[] DataTeamId()
        {
            return new[]
            {
                1, 2, 8, 2, 7, 5, 2, 2, 0, 1 //10
            };
        }
    }
}