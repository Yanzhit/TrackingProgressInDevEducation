using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QPayment : IQuery
    {
        public Type Type { get; } = typeof(Payment);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QPayment AddNewPayment(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(AddNewPayment);
            Params = $"{studentId}, {paymentTo}, {paymentOn}, {amount}, {status}";
            return this;
        }
        public QPayment ChangePaymentAmount(decimal amount, int id)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(ChangePaymentAmount);
            Params = $"{amount}, {id}";
            return this;
        }
        public QPayment ClosePayment(DateTime date, int id)
        {
            TypeQueries = TypeQueries.SetOne;
            Name = nameof(ClosePayment);
            Params = $"{date}, {id}";
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
            Params = $"{id}, {newDate}";
            return this;
        }
        public QPayment UpdatePaymentTeam(int id, DateTime newDate)
        {
            TypeQueries = TypeQueries.UpdateSeveral;
            Name = nameof(UpdatePaymentTeam);
            Params = $"{id}, {newDate}";
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