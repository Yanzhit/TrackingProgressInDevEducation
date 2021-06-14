﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Facades.Interfaces
{
    public interface ICities
    {
        City SetNewCity(City city);
        IEnumerable<City> GetCities();
        IEnumerable<City> NullifyCities();
    }
}