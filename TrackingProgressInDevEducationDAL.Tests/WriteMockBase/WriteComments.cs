using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Tests.DataMock;
using TrackingProgressInDevEducationDAL.Tests.ModelsMock;

namespace TrackingProgressInDevEducationDAL.Tests.WriteMockBase
{
    public class WriteComments : IWriteMock
    {
        private readonly DataComments _data = new();

        public void Write()
        {
            for(int i = 0; i < _data.Count; i++)
            {
                PreparationDB.Mock.Comments.Add(new MockComments(_data.Text[i], _data.TypeId[i], _data.StudentId[i], _data.CreatedBy[i]));
            }
        }
    }
}