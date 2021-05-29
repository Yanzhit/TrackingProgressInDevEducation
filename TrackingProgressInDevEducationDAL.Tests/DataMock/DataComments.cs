namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    public class DataComments
    {
        public string Text { get; }
        public int TypeId { get; }
        public int StudentId { get; }
        public int CreatedBy { get; }

        public DataComments(string text, int typeId, int studentId, int createdBy)
        {
            Text = text;
            TypeId = typeId;
            StudentId = studentId;
            CreatedBy = createdBy;
        }
    }
}