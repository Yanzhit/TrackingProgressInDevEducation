using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Payments
    {
        private readonly QPayment _qPayment = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Добавить платеж
        /// </summary>
        /// <param name="studentId">ИД Студента</param>
        /// <param name="paymentTo">Оплатить до</param>
        /// <param name="paymentOn">Оплачено</param>
        /// <param name="amount">Сумма</param>
        /// <param name="status">Статус платежа</param>
        /// <returns>Платеж</returns>
        public Payment AddNewPayment(int studentId, DateTime paymentTo, DateTime paymentOn, decimal amount, bool status)
        {
            return (Payment)_query.QuerySet(_qPayment.AddNewPayment(studentId, paymentTo, paymentOn, amount, status));
        }

        /// <summary>
        /// Поменять платеж студента
        /// </summary>
        /// <param name="amount">Сумма</param>
        /// <param name="id">Ид Студента</param>
        /// <returns>Платеж</returns>
        public Payment ChangePaymentAmount(decimal amount, int id)
        {
            return (Payment)_query.QuerySet(_qPayment.ChangePaymentAmount(amount, id));
        }

        /// <summary>
        /// Закрыть платеж
        /// </summary>
        /// <param name="date">Дата закрытия</param>
        /// <param name="id">Ид Студента</param>
        /// <returns>Платеж</returns>
        public Payment ClosePayment(DateTime date, int id)
        {
            return (Payment)_query.QuerySet(_qPayment.ClosePayment(date, id));
        }

        /// <summary>
        /// Удалить платеж по ID
        /// </summary>
        /// <param name="id">Ид студента</param>
        /// <returns>Платеж</returns>
        public Payment RemovePaymentById(int id)
        {
            return (Payment)_query.QuerySet(_qPayment.RemovePaymentById(id));
        }

        ///// <summary>
        ///// КОСЯК  НЕ ВИЖУ СТАТУСА
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="newDate"></param>
        ///// <returns></returns>
        //public Payment UpdatePaymentSetDateAndStatus(int id, DateTime newDate)
        //{
        //    return (Payment)_query.QuerySet(_qPayment.UpdatePaymentSetDateAndStatus(id, newDate));
        //}

        ///// <summary>
        ///// КОСЯК  ЧТО КОНКРЕТНО АПДЕЙТИТСЯ?
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="newDate"></param>
        ///// <returns></returns>
        //public Payment UpdatePaymentTeam(int id, DateTime newDate)
        //{
        //    return (Payment)_query.QuerySet(_qPayment.UpdatePaymentTeam(id, newDate));
        //}

        /// <summary>
        /// Вернуть все платежы группы
        /// </summary>
        /// <param name="group"></param>
        /// <returns>Cписок платежей</returns>
        public IEnumerable<Payment> GetAllPaymentsByGroup(int group)
        {
            return (IEnumerable<Payment>)_query.QuerySet(_qPayment.GetAllPaymentsByGroup(group));
        }

        /// <summary>
        /// Вернуть все платежи студента
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Cписок</returns>
        public IEnumerable<Payment> GetAllPaymentsByStudent(int student)
        {
            return (IEnumerable<Payment>)_query.QuerySet(_qPayment.GetAllPaymentsByStudent(student));
        }

        /// <summary>
        /// Обнуление платежей и ключа identity
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public IEnumerable<Payment> NullifyPayments(int student)
        {
            return (IEnumerable<Payment>)_query.QuerySet(_qPayment.NullifyPayments());
        }
    }
}