using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;


namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class GetAllPaymentsByStudent : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public GetAllPaymentsByStudent(int student)
        {
            Type = typeof(Payments);
            Name = "GetAllPaymentsByStudent";
            Params = $"{student}";
        }
    }
}
