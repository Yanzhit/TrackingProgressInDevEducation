using System;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class PreparationDB
    {
        private readonly FillingDB _fillingDB;
        private readonly NullifyDB _nullifyDB;

        public PreparationDB()
        {
            _fillingDB =  new FillingDB();
            _nullifyDB = new NullifyDB();
        }

        public void Filling(Type type)
        {
            _fillingDB.Filling(type);
        }

        public void Nullify(Type type)
        {
            
            _nullifyDB.Nullify(type);
        }
    }
}