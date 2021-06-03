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
            _nullifyDB = new NullifyDB();
            _fillingDB =  new FillingDB();
        }

        

        /// <summary>
        /// Обнуление таблиц по модели
        /// </summary>
        /// <param name="type"></param>
        public void Nullify(Type type)
        {
            _nullifyDB.Nullify(type);
        }
        public void Filling(Type type)
        {
            _fillingDB.Filling(type, _manager);
        }
    }
}