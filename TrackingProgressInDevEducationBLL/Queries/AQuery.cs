using System;
using System.Collections.Generic;
using System.Reflection;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Queries
{
    /// <summary>
    /// Абстрактная модель для всех запросов
    /// </summary>
    public abstract class AQuery
    {
        /// <summary>
        /// Массив типов данных для создания метода с необходимыми типами.
        /// </summary>
        private Type[] _type;

        /// <summary>
        /// Метод-Инфо для запроса работающего с одним объектом данных
        /// </summary>
        private MethodInfo _methodSingle;

        /// <summary>
        /// Метод-Инфо для запроса работающего с множественными объектами данных
        /// </summary>
        private MethodInfo _methodSeveral;

        /// <summary>
        /// Запись используемых типов в массив типов
        /// </summary>
        /// <param name="transfer">Интерфейс хранящий в себе используемые данные конкретным объектом</param>
        protected void WriteTypes(ITransfer transfer)
        {
            _type = new[]
            {
                transfer.Query,
                transfer.Base
            };
        }

        /// <summary>
        /// Получение базовой модели для одного объекта
        /// </summary>
        /// <param name="adtoQuery">Абстракция контейнера данных запроса</param>
        /// <returns>Абстрактную модель данных</returns>
        protected AbstractModel GetModelBaseSingle(ADTOQuery adtoQuery)
        {
            return Single(adtoQuery);
        }

        /// <summary>
        /// Получение базовой модели для получение списка объектов из BD
        /// </summary>
        /// <param name="adtoQuery">Абстракция контейнера данных запроса</param>
        /// <returns>Список абстрактную модель данных</returns>
        protected IEnumerable<AbstractModel> GetModelBaseSeveral(ADTOQuery adtoQuery)
        {
            return Several(adtoQuery);
        }

        /// <summary>
        /// Запрос на один объект
        /// </summary>
        /// <param name="model">Предоставленные данные в модели данных</param>
        /// <returns>Абстрактную модель после генерации метода с необходимыми параметрами и  отработки его</returns>
        private AbstractModel Single(ADTOQuery model)
        {
            GetMethodSingle();
            MethodInfo generic = GetGenericSingle();
            return (AbstractModel)generic.Invoke(null, new object[] { model });
        }

        /// <summary>
        /// Запрос на множество объектов
        /// </summary>
        /// <param name="model">Предоставленные данные в модели данных</param>
        /// <returns>Список абстрактных моделей после генерации метода с необходимыми параметрами и  отработки его</returns>
        private IEnumerable<AbstractModel> Several(ADTOQuery model)
        {
            GetMethodSeveral();
            MethodInfo generic = GetGenericSeveral();
            return (IEnumerable<AbstractModel>)generic.Invoke(null, new object[] { model });
        }

        /// <summary>
        /// Получение необходимого метода для запроса на один объект
        /// </summary>
        private void GetMethodSingle()
        {
            _methodSingle =  typeof(Mappers).GetMethod(nameof(Mappers.SingleMapping));
        }

        /// <summary>
        /// Получение необходимого метода для запроса на множество объект
        /// </summary>
        private void GetMethodSeveral()
        {
            _methodSeveral = typeof(Mappers).GetMethod(nameof(Mappers.SeveralMapping));
        }

        /// <summary>
        /// Получение дженерика по предоставленному массиву типов для одного объекта
        /// </summary>
        /// <returns></returns>
        private MethodInfo GetGenericSingle()
        {
            return _methodSingle.MakeGenericMethod(_type);
        }

        /// <summary>
        /// Получение дженерика по предоставленному массиву типов для множества объектов
        /// </summary>
        /// <returns></returns>
        private MethodInfo GetGenericSeveral()
        {
            return _methodSeveral.MakeGenericMethod(_type);
        }
    }
}