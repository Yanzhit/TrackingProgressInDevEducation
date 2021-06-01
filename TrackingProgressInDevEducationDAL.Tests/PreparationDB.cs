using System;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class PreparationDB
    {
        private readonly ManagerMocks _manager;
        private readonly FillingDB _fillingDB;
        private readonly NullifyDB _nullifyDB;

        public PreparationDB()
        {
            _manager = new ManagerMocks();
            _fillingDB =  new FillingDB();
            _nullifyDB = new NullifyDB();
        }

        public void Filling(Type type)
        {
            _fillingDB.Filling(type, _manager);
        }

        /// <summary>
        /// Обнуление таблиц по модели
        /// </summary>
        /// <param name="type"></param>
        public void Nullify(Type type)
        {
            
            _nullifyDB.Nullify(type);
        }
    }
}