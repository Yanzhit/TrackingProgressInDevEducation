using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QPayment : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Payment);
        public string Name { get; set; }
        public string Params { get; set; }

        public QPayment SetNewPayment(Payment payment)
        {
            QueryType = typeof(Getter);
            Name = nameof(SetNewPayment);
            Params = $"{SepStr}{payment.StudentId}{SepMid}{payment.PaymentTo}{SepMid}{payment.PaymentOn}" +
                     $"{SepMid}{payment.Amount}{SepMid}{payment.Status}{SepEnd}";
            return this;
        }

        public QPayment GetPaymentsByGroup()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetPaymentsByGroup);
            Params = string.Empty;
            return this;
        }

        public QPayment NullifyPayments()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyPayments);
            Params = string.Empty;
            return this;
        }

        //public QPayment ChangePaymentAmount(decimal amount, int id)
        //{
        //    Name = nameof(ChangePaymentAmount);
        //    Params = $"{amount}{Sep}{id}";
        //    return this;
        //}
        //public QPayment ClosePayment(DateTime date, int id)
        //{
        //    Name = nameof(ClosePayment);
        //    Params = $"{date}{Sep}{id}";
        //    return this;
        //}
        //public QPayment RemovePaymentById(int id)
        //{
        //    Name = nameof(RemovePaymentById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QPayment GetAllPaymentsByGroup(int group)
        //{
        //    Type = typeof(Payment);
        //    Name = nameof(GetAllPaymentsByGroup);
        //    Params = $"{group}";
        //    return this;
        //}
        //public QPayment GetAllPaymentsByStudent(int student)
        //{
        //    Type = typeof(Payment);
        //    Name = nameof(GetAllPaymentsByStudent);
        //    Params = $"{student}";
        //    return this;
        //}
        //public QPayment UpdatePaymentSetDateAndStatus(int id, DateTime newDate)
        //{
        //    Name = nameof(UpdatePaymentSetDateAndStatus);
        //    Params = $"{id}{Sep}{newDate}";
        //    return this;
        //}
        //public QPayment UpdatePaymentTeam(int id, DateTime newDate)
        //{
        //    Name = nameof(UpdatePaymentTeam);
        //    Params = $"{id}{Sep}{newDate}";
        //    return this;
        //}
    }
}