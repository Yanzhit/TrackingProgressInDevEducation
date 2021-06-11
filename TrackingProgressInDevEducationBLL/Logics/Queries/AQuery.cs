using System.Collections.Generic;
using System.Reflection;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Transfers;
using TrackingProgressInDevEducationDAL.Models;

namespace TrackingProgressInDevEducationBLL.Logics.Queries
{
    /// <summary>
    /// Абстрактная модель для всех запросов
    /// </summary>
    public abstract class AQuery : ARequest
    {
        protected override void WriteTypes(ATransfer aTransfer)
        {
            Types = new[]
            {
                aTransfer.Query,
                aTransfer.Base
            };
        }

        protected AbstractModel GetModelBaseSingle(ADTOQuery model)
        {
            return Single(model);
        }

        /// <summary>
        /// Получение базовой модели для получение списка объектов из BD
        /// </summary>
        /// <param name="model">Абстракция контейнера данных запроса</param>
        /// <returns>Список абстрактную модель данных</returns>
        protected IEnumerable<AbstractModel> GetModelBaseSeveral(ADTOQuery model)
        {
            return Several(model);
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
            GetInstansClass();
            return (AbstractModel)generic.Invoke(Instants, new object[] { model });
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
            GetInstansClass();
            return (IEnumerable<AbstractModel>)generic.Invoke(Instants, new object[] { model });
        }
    }
}