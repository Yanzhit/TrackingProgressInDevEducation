using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QPayment : IQuery
    {
        public Type Type { get; } = typeof(Payment);
        public string Name { get; set; }
        public string Params { get; set; }

        public QPayment AddNewPayment(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            Name = nameof(AddNewPayment);
            Params = $"{studentId}, {paymentTo}, {paymentOn}, {amount}, {status}";
            return this;
        }
        public QPayment ChangePaymentAmount(decimal amount, int id)
        {
            Name = nameof(ChangePaymentAmount);
            Params = $"{amount}, {id}";
            return this;
        }
        public QPayment ClosePayment(DateTime date, int id)
        {
            Name = nameof(ClosePayment);
            Params = $"{date}, {id}";
            return this;
        }
        public QPayment DeletePaymentById(int id)
        {
            Name = nameof(DeletePaymentById);
            Params = $"{id}";
            return this;
        }
        public QPayment GetAllPaymentsByGroup(int group)
        {
            Name = nameof(GetAllPaymentsByGroup);
            Params = $"{group}";
            return this;
        }
        public QPayment GetAllPaymentsByStudent(int student)
        {
            Name = nameof(GetAllPaymentsByStudent);
            Params = $"{student}";
            return this;
        }
        public QPayment UpdatePaymentSetDateAndStatus(int id, DateTime newDate)
        {
            Name = nameof(UpdatePaymentSetDateAndStatus);
            Params = $"{id}, {newDate}";
            return this;
        }
        public QPayment UpdatePaymentTerm(int id, DateTime newDate)
        {
            Name = nameof(UpdatePaymentTerm);
            Params = $"{id}, {newDate}";
            return this;
        }
        public QPayment NullifyPayments()
        {
            Name = nameof(NullifyPayments);
            Params = string.Empty;
            return this;
        }
    }
}