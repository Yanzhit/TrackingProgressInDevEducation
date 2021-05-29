using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Nullify;

namespace TrackingProgressInDevEducationDAL.Tests
{
    public class PreparationDB
    {
        public FillingDB fillingDB =  new FillingDB();
        public NullifyDB nullifyDB = new NullifyDB();
        public void Filling(Type type)
        {
            fillingDB.Filling(type);
        }

        public void Nullify(Type type)
        {
            
            nullifyDB.Nullify(type);
        }
    }
}