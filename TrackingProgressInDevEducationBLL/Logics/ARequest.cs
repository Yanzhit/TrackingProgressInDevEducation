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
        protected object Instants;
        /// <summary>
        /// Массив типов данных для создания метода с необходимыми типами.
        /// </summary>
        protected Type[] Types;

        /// <summary>
        /// Метод-Инфо для запроса работающего с одним объектом данных
        /// </summary>
        protected MethodInfo MethodSingle;

        /// <summary>
        /// Метод-Инфо для запроса работающего с множественными объектами данных
        /// </summary>
        protected MethodInfo MethodSeveral;

        /// <summary>
        /// Запись используемых типов в массив типов
        /// </summary>
        /// <param name="aTransfer">Интерфейс хранящий в себе используемые данные конкретным объектом</param>
        protected abstract void WriteTypes(ATransfer aTransfer);

        /// <summary>
        /// Получение необходимого метода для запроса на один объект
        /// </summary>
        protected void GetMethodSingle()
        {
            MethodSingle = typeof(Mappers).GetMethod(nameof(Mappers.SingleMapping));
        }

        /// <summary>
        /// Получение необходимого метода для запроса на множество объект
        /// </summary>
        protected void GetMethodSeveral()
        {
            MethodSeveral = typeof(Mappers).GetMethod(nameof(Mappers.SeveralMapping));
        }

        /// <summary>
        /// Получение дженерика по предоставленному массиву типов для одного объекта
        /// </summary>
        /// <returns></returns>
        protected MethodInfo GetGenericSingle()
        {
            return MethodSingle.MakeGenericMethod(Types);
        }

        /// <summary>
        /// Получение дженерика по предоставленному массиву типов для множества объектов
        /// </summary>
        /// <returns></returns>
        protected MethodInfo GetGenericSeveral()
        {
            return MethodSeveral.MakeGenericMethod(Types);
        }

        protected void GetInstansClass()
        {
            ConstructorInfo constructor = typeof(Mappers).GetConstructor(Type.EmptyTypes);
            Instants = constructor.Invoke(new object[]{});
        }
    }
}