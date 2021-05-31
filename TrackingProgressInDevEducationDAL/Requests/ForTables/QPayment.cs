using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QPayment : IQuery
    {
        public Type Type { get; } = typeof(Payment);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QPayment AddNewPayment(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewPayment);
            Params = $"{studentId}{Sep}{paymentTo}{Sep}{paymentOn}{Sep}{amount}{Sep}{status}";
            return this;
        }
        public QPayment ChangePaymentAmount(decimal amount, int id)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(ChangePaymentAmount);
            Params = $"{amount}{Sep}{id}";
            return this;
        }
        public QPayment ClosePayment(DateTime date, int id)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(ClosePayment);
            Params = $"{date}{Sep}{id}";
            return this;
        }
        public QPayment RemovePaymentById(int id)
        {
            TypeQueries = TypeQueries.RemoveOne;
            Name = nameof(RemovePaymentById);
            Params = $"{id}";
            return this;
        }
        public QPayment GetAllPaymentsByGroup(int group)
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetAllPaymentsByGroup);
            Params = $"{group}";
            return this;
        }
        public QPayment GetAllPaymentsByStudent(int student)
        {
            TypeQueries = TypeQueries.GetSeveral;
            Name = nameof(GetAllPaymentsByStudent);
            Params = $"{student}";
            return this;
        }
        public QPayment UpdatePaymentSetDateAndStatus(int id, DateTime newDate)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdatePaymentSetDateAndStatus);
            Params = $"{id}{Sep}{newDate}";
            return this;
        }
        public QPayment UpdatePaymentTeam(int id, DateTime newDate)
        {
            TypeQueries = TypeQueries.UpdateSeveral;
            Name = nameof(UpdatePaymentTeam);
            Params = $"{id}{Sep}{newDate}";
            return this;
        }
        public QPayment NullifyPayments()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyPayments);
            Params = string.Empty;
            return this;
        }
    }
}