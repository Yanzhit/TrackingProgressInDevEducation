using System;
using System.Reflection;
using TrackingProgressInDevEducationBLL.Transfers;

namespace TrackingProgressInDevEducationBLL.Logics
{
    /// <summary>
    /// Абстракция всех вопросов и ответов
    /// </summary>
    public abstract class ARequest
    {
        /// <summary>
        /// Массив типов данных для создания метода с необходимыми типами.
        /// </summary>
        protected Type[] _type;

        /// <summary>
        /// Метод-Инфо для запроса работающего с одним объектом данных
        /// </summary>
        protected MethodInfo _methodSingle;

        /// <summary>
        /// Метод-Инфо для запроса работающего с множественными объектами данных
        /// </summary>
        protected MethodInfo _methodSeveral;

        /// <summary>
        /// Запись используемых типов в массив типов
        /// </summary>
        /// <param name="transfer">Интерфейс хранящий в себе используемые данные конкретным объектом</param>
        protected abstract void WriteTypes(ITransfer transfer);

        /// <summary>
        /// Получение необходимого метода для запроса на один объект
        /// </summary>
        protected void GetMethodSingle()
        {
            _methodSingle = typeof(Mappers).GetMethod(nameof(Mappers.SingleMapping));
        }

        /// <summary>
        /// Получение необходимого метода для запроса на множество объект
        /// </summary>
        protected void GetMethodSeveral()
        {
            _methodSeveral = typeof(Mappers).GetMethod(nameof(Mappers.SeveralMapping));
        }

        /// <summary>
        /// Получение дженерика по предоставленному массиву типов для одного объекта
        /// </summary>
        /// <returns></returns>
        protected MethodInfo GetGenericSingle()
        {
            return _methodSingle.MakeGenericMethod(_type);
        }

        /// <summary>
        /// Получение дженерика по предоставленному массиву типов для множества объектов
        /// </summary>
        /// <returns></returns>
        protected MethodInfo GetGenericSeveral()
        {
            return _methodSeveral.MakeGenericMethod(_type);
        }
    }
}