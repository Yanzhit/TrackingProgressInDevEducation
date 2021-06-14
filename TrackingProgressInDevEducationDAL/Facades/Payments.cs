using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Payments : AFacade, IPayments
    {
        private readonly QPayment _query  = new();

        /// <summary>
        /// Добавить платеж
        /// </summary>
        /// <param name="payment">Объект данных</param>
        /// <returns>Платеж</returns>
        public Payment SetNewPayment(Payment payment)
        {
            return (Payment) Manager.Setter.Single
            (
                _query.SetNewPayment(payment));
        }

        public IEnumerable<Payment> GetPaymentsByGroup()
        {
            return (IEnumerable<Payment>)Manager.Getter.Several(_query.GetPaymentsByGroup());
        }

        /// <summary>
        /// Обнуление платежей и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Payment> NullifyPayments()
        {
            return (IEnumerable<Payment>)Manager.Remove.Rem(_query.NullifyPayments());
        }

        /////// <summary>
        /////// Поменять платеж студента
        /////// </summary>
        /////// <param name="amount">Сумма</param>
        /////// <param name="id">Ид Студента</param>
        /////// <returns>Платеж</returns>
        ////public Payment ChangePaymentAmount(decimal amount, int id)
        ////{
        ////    return (Payment)Manager.Update.Upd(Query.ChangePaymentAmount(amount, id));
        ////}

        /////// <summary>
        /////// Закрыть платеж
        /////// </summary>
        /////// <param name="date">Дата закрытия</param>
        /////// <param name="id">Ид Студента</param>
        /////// <returns>Платеж</returns>
        ////public Payment ClosePayment(DateTime date, int id)
        ////{
        ////    return (Payment)Manager.Update.Upd(Query.ClosePayment(date, id));
        ////}

        ///// <summary>
        ///// Удалить платеж по ID
        ///// </summary>
        ///// <param name="id">Ид студента</param>
        ///// <returns>Платеж</returns>
        //public Payment RemovePaymentById(int id)
        //{
        //    return (Payment)Manager.Remove.Rem(Query.RemovePaymentById(id));
        //}

        /////// <summary>
        /////// КОСЯК  НЕ ВИЖУ СТАТУСА
        /////// </summary>
        /////// <param name="id"></param>
        /////// <param name="newDate"></param>
        /////// <returns></returns>
        ////public Payment UpdatePaymentSetDateAndStatus(int id, DateTime newDate)
        ////{
        ////    return (Payment)_query.Manager(_qPayment.UpdatePaymentSetDateAndStatus(id, newDate));
        ////}

        /////// <summary>
        /////// КОСЯК  ЧТО КОНКРЕТНО АПДЕЙТИТСЯ?
        /////// </summary>
        /////// <param name="id"></param>
        /////// <param name="newDate"></param>
        /////// <returns></returns>
        ////public Payment UpdatePaymentTeam(int id, DateTime newDate)
        ////{
        ////    return (Payment)_query.Manager(_qPayment.UpdatePaymentTeam(id, newDate));
        ////}

        ///// <summary>
        ///// Вернуть все платежи группы
        ///// </summary>
        ///// <param name="group"></param>
        ///// <returns>Списки платежей</returns>
        //public IEnumerable<Payment> GetAllPaymentsByGroup(int group)
        //{
        //    return (IEnumerable<Payment>)Manager.Getter.Several(Query.GetAllPaymentsByGroup(group));
        //}

        ///// <summary>
        ///// Вернуть все платежи студента
        ///// </summary>
        ///// <param name="student"></param>
        ///// <returns>Список</returns>
        //public IEnumerable<Payment> GetAllPaymentsByStudent(int student)
        //{
        //    return (IEnumerable<Payment>)Manager.Getter.Several(Query.GetAllPaymentsByStudent(student));
        //}
    }
}