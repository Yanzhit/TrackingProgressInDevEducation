using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.DataMock;

namespace TrackingProgressInDevEducationDAL.Tests.WriteMockBase
{
    public class WriteComments : IWriteMock 
    {
        private readonly DataComment _data = new();

        public void Write()
        {
            for (int i = 0; i < _data.Text.Length; i++)
            {
                PreparationDB.Mock.Comments.Add(new Comment(_data.Text[i], _data.TypeId[i], _data.StudentId[i], _data.CreatedBy[i], _data.TeamId[i]));
            }
        }
    }
}